using Microsoft.AspNetCore.Components.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Exercice_4_MVC.Service
{
    public class WarehouseService
    {
        public string GenerateCode()
        {
            // Générer une chaîne aléatoire de 8 caractères
            string randomString = GenerateRandomString(8);

            var generatedHash = GenerateHash(randomString);

            return generatedHash.Substring(0, 8);
            
        }

        public bool VerifyCode(string inputText, string hash)
        {
            var generatedHash = GenerateHash(inputText);

            // Comparer le hash généré avec le hash fourni
            return generatedHash.Equals(hash, StringComparison.OrdinalIgnoreCase);
        }

        private string GenerateHash(string inputText)
        {
            string toReturn;
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(inputText);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convertir le tableau de bytes en une chaîne hexadécimale
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                toReturn = sb.ToString();
            }
            return toReturn;
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
