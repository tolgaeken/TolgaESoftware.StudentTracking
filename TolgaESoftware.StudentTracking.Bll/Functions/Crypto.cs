using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TolgaESoftware.StudentTracking.Bll.Functions
{
    public static class Crypto
    {
        public static string Encrypt(this string willBeEncryptedData, string key)
        {
            if (willBeEncryptedData == null) return null;
            var willBeEncyptedDataToByte = Encoding.UTF8.GetBytes(willBeEncryptedData);
            var keyToByte = Encoding.UTF8.GetBytes(key);

            keyToByte = SHA256.Create().ComputeHash(keyToByte);

            byte[] encryptedData;
            //byte[] encryptedData = null;

            var saltBytes = new byte[] {1, 2, 3, 4, 5, 6, 7, 8};

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var encryptKey = new Rfc2898DeriveBytes(keyToByte, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = encryptKey.GetBytes(aes.KeySize / 8);
                    aes.IV = encryptKey.GetBytes(aes.BlockSize / 8);

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(willBeEncyptedDataToByte, 0, willBeEncyptedDataToByte.Length);
                        cs.Close();
                    }
                    encryptedData = ms.ToArray();
                }
            }

            return Convert.ToBase64String(encryptedData);
        }

        public static string Decrypt(this string willBeDecryptedData, string key)
        {
            if (willBeDecryptedData == null) return null;
            var willBeDecryptedDataToByte = Convert.FromBase64String(willBeDecryptedData);
            var keyToByte = Encoding.UTF8.GetBytes(key);

            keyToByte = SHA256.Create().ComputeHash(keyToByte);

            byte[] decryptedData;
            var saltByte = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var decryptKey = new Rfc2898DeriveBytes(keyToByte, saltByte, 1000);
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = decryptKey.GetBytes(aes.KeySize / 8);
                    aes.IV = decryptKey.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(willBeDecryptedDataToByte, 0, willBeDecryptedDataToByte.Length);
                        cs.Close();
                    }
                    decryptedData = ms.ToArray();

                }
            }

            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}