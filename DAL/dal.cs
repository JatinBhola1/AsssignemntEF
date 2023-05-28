using BusinessObject.Models;
using DAL.Context;

namespace DAL
{
    public class dal
    {
        public  void AddInventory(int id,Inventory inventory)
        {

            InventoryDbContext db = new InventoryDbContext();
             Supplier supp = db.Suppliers.FirstOrDefault(x => x.SupplierID == id);
            

            db.Inventories.Add(inventory);
            db.SaveChanges();
        }
        public  void AddSupplier(Supplier supplier)
        {
            InventoryDbContext db = new InventoryDbContext();
            
            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }

        public  void DeleteSupplier(int id,Supplier supplier)
        {
            InventoryDbContext db = new InventoryDbContext();
            Supplier b = db.Suppliers.Where(x => x.SupplierID == id).FirstOrDefault();
            if (b != null)
            {
                db.Suppliers.Remove(b);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("There is no Record");
            }
        }
        public  void EditSupplier(int id,Supplier supplier)
        {
            InventoryDbContext db = new InventoryDbContext();
            Supplier bob = db.Suppliers.Where(x => x.SupplierID == id).FirstOrDefault();
            if (bob != null)
            {
                foreach (Supplier temp in db.Suppliers)
                {
                    if (temp.SupplierID == bob.SupplierID)
                    {
                        temp.Address = "Its a New Address";
                    }
                }
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("There is No Record");
            }
        }
        public void EditInventory(int id, Inventory inventory)
        {
            InventoryDbContext db = new InventoryDbContext();
            Inventory bob = db.Inventories.Where(x => x.Id == id).FirstOrDefault();
            if (bob != null)
            {
                foreach (Inventory temp in db.Inventories)
                {
                    if (temp.Id == bob.Id)
                    {
                        temp.Details = "Its a New Edited detail";
                    }
                }
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("There is No Record");
            }


        }

        public  void DisplaySupplier(Supplier supplier)
        {
            InventoryDbContext db = new InventoryDbContext();
            List<Supplier> list = new List<Supplier>();
            list = db.Suppliers.ToList();
            foreach (Supplier temp in list)
            {
                Console.WriteLine($"{temp.SupplierID}--{temp.SupplierName}--{temp.Address}--{temp.ContactNo}--{temp.Email}--{temp.CityOperatesIn}");
            }
        }
        public  void DisplayInventory(Inventory inventory)
        {
            InventoryDbContext db = new InventoryDbContext();
            List<Inventory> list = new List<Inventory>();
            list = db.Inventories.ToList();
            //foreach (Inventory temp in list)
            //{
            //    Console.WriteLine($"{temp.Id}--{temp.Name}--{temp.Details}--{temp.QtyInStock}--{temp.LastUpdated}");
            //}
            var query = from Supplier in db.Suppliers
                        join Inventory in db.Inventories
                        on Supplier.SupplierID equals Inventory.supplier.SupplierID
                        select new
                        {
                            InventoryId = Inventory.Id,
                            InventoryDetails = Inventory.Details,
                            InventoryLastUpdated = Inventory.LastUpdated,
                            SupplierId = Inventory.supplier.SupplierID,
                            InventoryName = Inventory.Name,
                            Quantity = Inventory.QtyInStock,
                            SupplierName = Supplier.SupplierName,
                            city = Supplier.CityOperatesIn

                        };
            foreach (var order in query)
            {
                Console.WriteLine($"{order.InventoryId}--{order.InventoryName}--{order.InventoryDetails}--{order.Quantity}--{order.InventoryLastUpdated}--{order.SupplierId}--{order.SupplierName}");
            }

        }

        public  void DeleteInventory(int id, Inventory inventory)
        {
            InventoryDbContext db = new InventoryDbContext();
            Inventory b = db.Inventories.Where(x => x.Id == id).FirstOrDefault();
            if (b != null)
            {
                db.Inventories.Remove(b);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("There is no Record");
            }
        }
       

    }
}