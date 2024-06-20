using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace HRM
{
    public class encryption
    {
        // Алгоритм шифрования AES
        public static string Encrypt(string plainText, string _key = "ExIspo_key=12")
        {
            byte[] key, iv;
            GenerateKeyAndIV(_key, out key, out iv);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText, string _key = "ExIspo_key=12")
        {
            byte[] key, iv;
            GenerateKeyAndIV(_key, out key, out iv);

            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }

        // Генерация ключа и вектора инициализации из строки-ключа
        private static void GenerateKeyAndIV(string keyString, out byte[] key, out byte[] iv)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(keyString + "key"));
                byte[] ivBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(keyString + "iv"));

                key = new byte[32]; // AES-256 использует 32-байтный ключ
                iv = new byte[16];  // AES использует 16-байтный IV

                Array.Copy(keyBytes, 0, key, 0, 32);
                Array.Copy(ivBytes, 0, iv, 0, 16);
            }
        }
    }
}
