using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Warehouse
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int PostalCode { get; set; }


        /// <summary>
        /// Cette liste contient les codes accès du warehouse en md5.
        /// </summary>
        public List<string> CodeAccesMD5 { get; set; } = new();

        public List<Order> Orders { get; set; }

    }
}
