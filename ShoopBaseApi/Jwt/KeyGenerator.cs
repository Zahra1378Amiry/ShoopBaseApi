using System;
using System.Security.Cryptography;

namespace ShoopBaseApi.Jwt
{
    public static class KeyGenerator
    {
        // متد تولید کلید به اندازه 32 بایت (256 بیت)
        public static string GenerateRandomKey(int size = 32) // به صورت پیش‌فرض 32 بایت = 256 بیت
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[size];
                rng.GetBytes(key);
                return Convert.ToBase64String(key);
            }
        }

        public static void Main(string[] args)
        {
            // ایجاد یک کلید 256 بیتی (32 بایت)
            string key = GenerateRandomKey();
            Console.WriteLine("Generated Key (Base64): " + key);
        }
    }
}
