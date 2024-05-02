using Exercice_4_MVC.Data;
using Exercice_4_MVC.Models;
using Microsoft.AspNetCore.Components.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Exercice_4_MVC.Service
{
    public class WarehouseService
    {

        private static DbContext dbContext = new DbContext();


        public List<Warehouse> GetWarehouses()
        {
            return dbContext.Warehouses;
        }

        public void Add(Warehouse newWarehouse)
        {
            dbContext.Warehouses.Add(newWarehouse);
        }

        public void Remove(Warehouse newWarehouse)
        {
            dbContext.Warehouses.Remove(newWarehouse);
        }

        public string GenerateCode(int warehouseId)
        {
            // Générer une chaîne aléatoire de 8 caractères
            string code = GenerateRandomString(8);

            var hashedCode = GenerateHash(code);

            var currentWarehouse = dbContext.Warehouses.SingleOrDefault(w => w.Id == warehouseId);
            if (currentWarehouse == null)
                throw new Exception("Warehouse inconnu");
            currentWarehouse!.CodeAccesMD5.Add(hashedCode);

            return code;

        }

        public bool VerifyCode(int warehouseId,string inputText)
        {
            var userInputCode = GenerateHash(inputText);

            var currentWarehouse = dbContext.Warehouses.SingleOrDefault(w => w.Id == warehouseId);
            foreach (var code in currentWarehouse.CodeAccesMD5)
            {
                // Comparer le hash stocké avec le hash fourni
                if (code == userInputCode)
                    return true;
            }
           
            return false;
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
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
