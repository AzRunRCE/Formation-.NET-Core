using Exercice_4_MVC.Controllers;
using Exercice_4_MVC.Models;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace Exercice_4_MVC.Data
{
    public class DbContext
    {

        public List<Warehouse> Warehouses = new List<Warehouse>()
                {
                    new Warehouse()
                    {
                        Id = 1,
                        Name = "Entrepot de Paris",
                        Address = "10 rue du csharp",
                        PostalCode = 75000,
                        CodeAccesMD5 = new()
                        {
                            "840e998a22948adf5de39bd4f2b35da7",
                            "74b87337454200d4d33f80c4663dc5e5",
                        }
                    },
                    new Warehouse()
                    {
                                Id = 2,
                                Name = "Entrepot de Nantes",
                                Address = "15 rue de .net",
                                PostalCode = 44300,
                                CodeAccesMD5 = new()
                                {
                                    "c907644684bf002564d91989c222518a",
                                    "57fcb3ea27b6d1b9993405adcd0f69ca",
                                }
                    }
    };
    }
}
