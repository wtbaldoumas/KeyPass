using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace KeyPassBusiness
{
    public static class Cryptographer
    {
        private static readonly int _iterations = 9973;
        private static readonly int _keySize = 256;

        //*************************************************************************************************************
        // For encryption, the salt and initialization vector are randomly generated, then prepended to the encrypted *
        // file for later use rather than being saved as member variables. The encryption key is generated with the   *
        // byte array that was created by hashing the password in addtion to the randomly generated salt.             *
        //*************************************************************************************************************
        public static byte[] Encrypt(byte[] plainBuffer, byte [] passwordBytes)
        {
            byte[] salt = GenerateEntropicBytes();
            byte[] iv = GenerateEntropicBytes();

            using (Rijndael rijndael = Rijndael.Create())
            {
                rijndael.BlockSize = _keySize;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.PKCS7;
                rijndael.Key = GenerateKey(passwordBytes, salt, _iterations);
                rijndael.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainBuffer, 0, plainBuffer.Length);
                        cryptoStream.FlushFinalBlock();
                        byte[] cipher = salt;
                        cipher = cipher.Concat(iv).ToArray();
                        cipher = cipher.Concat(memoryStream.ToArray()).ToArray();
                        return cipher;
                    }
                }
            }
        }

        //*******************************************************************************************************
        // For decryption, the salt and initialization vector are extracted from the beginning of the file to   *
        // be used to generate the correct key. The file is then decrypted into a memory stream which is passed *
        // back to the KeyPassManager which then populates the various controls with the correct values.        *
        //*******************************************************************************************************
        public static byte[] Decrypt(byte[] cipherBuffer, byte [] passwordBytes)
        {
            byte[] salt = cipherBuffer.Take(_keySize / 8).ToArray();
            byte[] iv = cipherBuffer.Skip(_keySize / 8).Take(_keySize / 8).ToArray();
            byte[] cipherDecrypt = cipherBuffer.Skip((_keySize / 8) * 2).Take(cipherBuffer.Length - ((_keySize / 8) * 2)).ToArray();

            using (Rijndael rijndael = Rijndael.Create())
            {
                rijndael.BlockSize = _keySize;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.PKCS7;
                rijndael.Key = GenerateKey(passwordBytes, salt, _iterations);
                rijndael.IV = iv;


                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(cipherDecrypt, 0, cipherDecrypt.Length);
                        return memoryStream.ToArray();
                    }
                }
            }
        }

        //*****************************************************
        // Utility for generating encryption/decryption keys. *
        //*****************************************************
        public static byte[] GenerateKey(byte [] passwordBytes, byte [] salt, int iterations)
        {
            using (Rfc2898DeriveBytes passwordDerivedBytes = new Rfc2898DeriveBytes(passwordBytes, salt, iterations))
            {
                return passwordDerivedBytes.GetBytes(32);
            }
        }

        //*************************************************************
        // Utility for generating the initialization vector and salt. *
        //*************************************************************
        public static byte[] GenerateEntropicBytes()
        {
            byte [] entropicBytes = new byte[0x20];
            using (RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                cryptoServiceProvider.GetBytes(entropicBytes);
            }
            return entropicBytes;
        }
    }
}
