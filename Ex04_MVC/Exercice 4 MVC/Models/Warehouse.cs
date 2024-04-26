namespace Exercice_4_MVC.Models
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int PostalCode { get; set; }

        public int ActivationCode { get; set; }
    }
}
