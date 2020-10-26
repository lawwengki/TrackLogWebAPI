using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoreBaseLib.Core.Helpers
{
    public class EncryptHelper
    {
        private const string cryptoKey = "hawoooWeb";

        // The Initialization Vector for the DES encryption routine
        private static readonly byte[] IV =
            new byte[8] { 240, 3, 45, 29, 0, 76, 173, 59 };

        /// <summary>
        /// Encrypts provided string parameter
        /// </summary>
        public static string Encrypt(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            string result = string.Empty;

            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(s);

                TripleDESCryptoServiceProvider des =
                    new TripleDESCryptoServiceProvider();

                MD5CryptoServiceProvider MD5 =
                    new MD5CryptoServiceProvider();

                des.Key =
                    MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(cryptoKey));

                des.IV = IV;
                result = Convert.ToBase64String(
                    des.CreateEncryptor().TransformFinalBlock(
                        buffer, 0, buffer.Length));
            }
            catch
            {
                throw;
            }

            return result;
        }

        /// <summary>
        /// Decrypts provided string parameter
        /// </summary>
        public static string Decrypt(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            string result = string.Empty;

            try
            {
                byte[] buffer = Convert.FromBase64String(s);

                TripleDESCryptoServiceProvider des =
                    new TripleDESCryptoServiceProvider();

                MD5CryptoServiceProvider MD5 =
                    new MD5CryptoServiceProvider();

                des.Key =
                    MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(cryptoKey));

                des.IV = IV;

                result = Encoding.ASCII.GetString(
                    des.CreateDecryptor().TransformFinalBlock(
                    buffer, 0, buffer.Length));
            }
            catch
            {
                throw;
            }

            return result;
        }

        public static string GenerateSHA1String(string inputString)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var passwordBytes = Encoding.UTF8.GetBytes(inputString);
            var passwordHash = sha1.ComputeHash(passwordBytes);
            var signature = BitConverter.ToString(passwordHash).Replace("-", string.Empty).ToLowerInvariant();
            return signature;
        }

        public static string GenerateSHA256String(string inputString)
        {
            SHA256 SHA256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = SHA256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString().ToLower();
        }
    }
}
