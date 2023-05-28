using BusinessObject.Models;

namespace BAL
{
    public class Class1
    {
        DAL.dal  dall = new DAL.dal();
        public int AddSupplier(Supplier supplier)
        {
            dall.AddSupplier(supplier);
            return 0;
        }
        public int AddInventory(int id,Inventory inventory)
        {
            dall.AddInventory(id,inventory);
            return 0;
        }
        public int DeleteSupplier(int id,Supplier supplier)
        {
            dall.DeleteSupplier(id, supplier);
            return 0;
        }
        public int DeleteInventory(int id,Inventory inventory)
        {
            dall.DeleteInventory(id, inventory);
            return 0;
        }
        public int EditSupplier(int id,Supplier supplier)
        {
            dall.EditSupplier(id, supplier);
            return 0;
        }
        public int EditInventory(int id,Inventory inventory)
        {
            dall.EditInventory(id, inventory);
            return 0;
        }
        public int DisplaySupplier(Supplier supplier)
        {
            dall.DisplaySupplier(supplier);
            return 0;
        }
        public int DisplayInventory(Inventory inventory)
        {
            dall.DisplayInventory(inventory);
            return 0;
        }

    }
}