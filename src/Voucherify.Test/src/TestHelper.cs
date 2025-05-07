using System;
using System.Threading.Tasks;
using Voucherify.Client;
using Voucherify.Model;

namespace Voucherify.Test
{
    public static class TestHelper
    {
        public static string GenerateRandomString(int length = 8)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[length];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }

        public static string GenerateUniqueEmail()
        {
            return $"test-{GenerateRandomString()}@voucherify-test.com";
        }

        public static string GenerateUniqueName(string prefix = "Test")
        {
            return $"{prefix}-{GenerateRandomString()}";
        }
    }
}