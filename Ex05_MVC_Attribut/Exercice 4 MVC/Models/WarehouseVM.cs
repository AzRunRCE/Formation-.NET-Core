namespace Exercice_5_MVC.Models
{
    public class WarehouseVM
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int PostalCode { get; set; }


        /// <summary>
        /// Cette liste contient les codes accès du warehouse en md5.
        /// </summary>
        public List<string> CodeAccesMD5 { get; set; } = new();



    }
}
