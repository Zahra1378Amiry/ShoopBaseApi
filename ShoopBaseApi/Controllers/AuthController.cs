using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;
using ShoopBaseApi.Repository;

namespace ShoopBaseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUser _user; // مخزن کاربر
        private readonly IConfiguration _config;

        public AuthController(IUser user, IConfiguration config)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto userLogin)
        {
            // بررسی نام کاربری و رمز عبور با استفاده از مخزن کاربر
            var user = await _user.ChekUserAsync(userLogin.UserName, userLogin.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            // ایجاد ادعاها (Claims)
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, "Admin") // به عنوان مثال، نقش کاربر
            };

            // تولید کلید و امضای توکن
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // تولید توکن
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            // بازگشت توکن
            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
    }
}
