using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;
using ShoopBaseApi.Repository;

namespace ShoopBaseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        private readonly IMapper _mapper;
        private readonly ILogger<UserController> _logger;

        public UserController(IUser user, IMapper mapper, ILogger<UserController> logger)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        #region Get Chek

        [HttpGet]
        public async Task<ActionResult<UserResponseDto>> ChekUser(string UserName, string Password)
        {
            try
            {


                var users = await _user.ChekUserAsync(UserName, Password);

                if (users == null)
                {
                    var error = new UserResponseDto
                    {
                        Status = 404,
                        Message = "کاربر پیدا نشد ",
                        IsSuccess = false,
                        FristName = null,
                        LastName = null,
                        Images = null,
                        ID_User = 0,

                    };
                    return NotFound(error);
                }

                var success = new UserResponseDto
                {
                    Status = 200,
                    Message = "کابر با موفیت پیدا شد",
                    IsSuccess = true,
                    ID_User = users.ID_User,
                    FristName = users.FristName,
                    LastName = users.LastName,
                    Images = users.Images,
                };

                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred .");

                var error = new ErrorDto
                {
                    Message = "خطا رخ داد.",
                    Success = false,
                };

                return BadRequest(error);
            }

        }
        #endregion

        #region Add

        [HttpPost]
        public async Task<ActionResult<UserResponseDto>> CreatedUser(UserCreationDto userCreationDto)
        {

            try
            {
                var existingUserByUsername = await _user.GetUserByUsernameAsync(userCreationDto.UserName);
                if (existingUserByUsername != null)
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "کاربری با این نام کاربری قبلاً ثبت شده است",
                        IsSuccess = false,
                    };
                    return NotFound(error);
                }

                var existingUserByMobile = await _user.GetUserByMobileAsync(userCreationDto.Mobile);
                if (existingUserByMobile != null)
                {
                    var Error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "این شماره موبایل قبلاً ثبت شده است",
                        IsSuccess = false,
                    };
                    return NotFound(Error);
                }

                var newUser = _mapper.Map<T_User>(userCreationDto);
                newUser.ISActive = true;
                await _user.AddUserAsync(newUser);
                await _user.SaveAsync();

                var success = new UserResponseDto
                {
                    Status = 200,
                    Message = "کابر با موفیت ثبت نام شد",
                    IsSuccess = true,
                    ID_User = newUser.ID_User,
                    FristName = newUser.FristName,
                    LastName = newUser.LastName,
                    Images = newUser.Images,
                };

                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred.");
                var error = new ErrorDto
                {
                    Message = "خطا رخ داد.",
                    Success = false,
                };

                return BadRequest(error);

            }

          
        }
        #endregion

        #region Edite

        [HttpPut]
        public async Task<ActionResult> UpdateUser(long UserId, UserUpdateDto userUpdateDto)
        {
            try
            {
                var userupdete = await _user.GetUserByIdAsync(UserId);
                if (userupdete == null)
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "شناسه کابری پیدا نشد",
                        IsSuccess = false,
                    };
                    return NotFound(error);
                }

                UserUpdateDto emp1 = new UserUpdateDto();
                emp1 = _mapper.Map<UserUpdateDto>(userupdete);
                emp1.FristName = userUpdateDto.FristName;
                emp1 .LastName = userUpdateDto.LastName;
                emp1.Emile = userUpdateDto.Emile;
                emp1.Mobile = userUpdateDto.Mobile;
                emp1.Password = userUpdateDto.Password;
                emp1.Images = userUpdateDto.Images;
                
               _mapper.Map(userUpdateDto, userupdete);
                await _user.SaveAsync();

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "کاربر با موفقیت به روزرسانی شد",
                    IsSuccess = true,
                 
                };

                return Ok(success);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred .");

                var error = new ErrorDto
                {
                    Message = "خطا رخ داد.",
                    Success = false,
                };

                return BadRequest(error);
            }

        }

        #endregion
    }
}
