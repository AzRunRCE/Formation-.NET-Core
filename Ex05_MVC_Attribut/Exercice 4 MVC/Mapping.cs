using BO;
using Exercice_5_MVC.Models;

namespace Exercice_5_MVC
{
    public class Mapping
    {
       public static WarehouseVM  ConvertToWarehouseVM(Warehouse warehouse)
        {
            var vm = new WarehouseVM();
            vm.Id = warehouse.Id;
            vm.Address = warehouse.Address;
            vm.Name = warehouse.Name;
            vm.PostalCode = warehouse.PostalCode;
            return vm;
        }

        public static Warehouse ToWarehouse(WarehouseVM wm)
        {
            var warehouse = new Warehouse();
            warehouse.Id = wm.Id;
            warehouse.Address = wm.Address;
            warehouse.Name = wm.Name;
            warehouse.PostalCode = wm.PostalCode;

            return warehouse;
        }
    }
}
