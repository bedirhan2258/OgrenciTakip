
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace OgrenciTakip.BLL.Functions
{
    public static class Crypto
    {

        public static string Encrypt(this string sifrelenecekVeri, string anahtar)
        {
            if (sifrelenecekVeri == null) return null;
            var sifrelenecekVeriToByte = Encoding.UTF8.GetBytes(sifrelenecekVeri);
            var anahtarToByte = Encoding.UTF8.GetBytes(anahtar);

            anahtarToByte = SHA256.Create().ComputeHash(anahtarToByte);

            byte[] sifreliVeri = null;

            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(anahtarToByte, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(sifrelenecekVeriToByte, 0, sifrelenecekVeriToByte.Length);
                        cs.Close();
                    }

                    sifreliVeri = ms.ToArray();
                }
            }

            return Convert.ToBase64String(sifreliVeri);
        }
        public static string Decrypt(this string sifresiCozulecekVeri, string anahtar)
        {
            if (sifresiCozulecekVeri == null) return null;
            var sifresiCozulecekVeriToByte = Convert.FromBase64String(sifresiCozulecekVeri);
            var anahtarToByte = Encoding.UTF8.GetBytes(anahtar);

            anahtarToByte = SHA256.Create().ComputeHash(anahtarToByte);

            byte[] sifresiCozulmusVeri;
            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(anahtarToByte, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(sifresiCozulecekVeriToByte, 0, sifresiCozulecekVeriToByte.Length);
                        cs.Close();
                    }

                    sifresiCozulmusVeri = ms.ToArray();
                }
            }

            return Encoding.UTF8.GetString(sifresiCozulmusVeri);
        }

    }
}
