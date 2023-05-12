using AsssignemntEF.Context;
using AsssignemntEF.Models;

namespace AsssignemntEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose The Option on which you Want to do CURD operation");
            char choice = 'y';
            byte che;
            byte ch;
            while(choice=='y')
            {
                Console.WriteLine("1.Supplier");
                Console.WriteLine("2.Inventory");
                che=byte.Parse(Console.ReadLine());
                switch(che)
                {
                    case 1:
                        {
                            while (choice == 'y') 
                            {
                                Console.WriteLine("1.Add Supplier");
                                Console.WriteLine("2.Delete Supplier ");
                                Console.WriteLine("3.Edit Supplier");
                                Console.WriteLine("4.List of Supplier");
                                Console.WriteLine("Enter Your Choice");

                                ch = byte.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1:
                                        {
                                            AddSupplier();
                                            Console.WriteLine("Supplier succesfully Added");
                                            break;
                                        }
                                    case 2:
                                        {
                                            DeleteSupplier();
                                            Console.WriteLine("Supplier succesfully Deleted");
                                            break;
                                        }
                                    case 3:
                                        {
                                            EditSupplier();
                                            Console.WriteLine("Supplier succesfully Edited");
                                            break;
                                        }
                                    case 4:
                                        {
                                            DisplaySupplier();
                                            Console.WriteLine("Suppliers succesfully Displayed");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Enter a Valid option");
                                            break;
                                        }
                                }
                                Console.WriteLine("Press Y to Continue");
                                choice = Char.Parse(Console.ReadLine());
                            }
                            
                            break;
                        }
                    case 2:
                        {
                            while(choice=='y')
                            {
                                Console.WriteLine("1.Add Inventory");
                                Console.WriteLine("2.Delete Inventory ");
                                Console.WriteLine("3.Edit Inventory");
                                Console.WriteLine("4.List of Inventory");
                                Console.WriteLine("Enter Your Choice");

                                ch = byte.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1:
                                        {
                                            AddInventory();
                                            Console.WriteLine("Inventory Succesfully Added");
                                            break;
                                        }
                                    case 2:
                                        {
                                            DeleteSupplier();
                                            Console.WriteLine("Inventory Succesfully Deleted");
                                            break;
                                        }
                                    case 3:
                                        {
                                            EditInventory();
                                            Console.WriteLine("Inventory Succesfully Edited");
                                            break;
                                        }
                                    case 4:
                                        {
                                            DisplayInventory();
                                            Console.WriteLine("Inventories Succesfully Displayed");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Enter a Valid option");
                                            break;
                                        }


                                }
                                Console.WriteLine("Press Y to Continue");
                                choice = Char.Parse(Console.ReadLine());
                            }
                            
                            break;

                        }
                        default :
                        {
                            Console.WriteLine("Enter a valid Option");
                            break;
                        }
                }
                Console.WriteLine("Press Y to Continue");
                choice = (char)byte.Parse(Console.ReadLine());
            }
        }
        public static void AddSupplier()
        {
            InventoryDbContext db = new InventoryDbContext();
            Supplier supplier = new Supplier()
            {
                SupplierName = "Ajay",
                Address = "New Delhi",
                ContactNo="9910199101",
                Email="hdkjdwcn@gmail.com",
                CityOperatesIn="Delhi"
            };
            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }
        public static void AddInventory()
        {

            InventoryDbContext db = new InventoryDbContext();
            Supplier sup = db.Suppliers.FirstOrDefault(x => x.SupplierID == 2);
            Inventory inventory = new Inventory()
            {
                Name = "Pen",
                Details = "Good Pen",
                QtyInStock = 50,
                LastUpdated = Convert.ToDateTime("12/12/2022"),
                supplier = sup
            
            };
            db.Inventories.Add(inventory);
            db.SaveChanges();
        }




        public static void DeleteSupplier()
        {
            InventoryDbContext db = new InventoryDbContext();
            Supplier b = db.Suppliers.Where(x => x.SupplierID == 1).FirstOrDefault();
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

        public static void DeleteInventory()
        {
            InventoryDbContext db = new InventoryDbContext();
            Inventory b = db.Inventories.Where(x => x.Id == 1).FirstOrDefault();
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



        public static void EditSupplier()
        { 
            InventoryDbContext db= new InventoryDbContext();
            Supplier bob = db.Suppliers.Where(x => x.SupplierID == 2).FirstOrDefault();
            if(bob!= null)
            {
                foreach(Supplier temp in db.Suppliers)
                {
                    if(temp.SupplierID==bob.SupplierID)
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
        public static void EditInventory()
        {
            InventoryDbContext db = new InventoryDbContext();
            Inventory bob = db.Inventories.Where(x => x.Id == 2).FirstOrDefault();
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



        public static void DisplaySupplier()
        {
            InventoryDbContext db = new InventoryDbContext();
            List<Supplier> list = new List<Supplier>();
            list = db.Suppliers.ToList();
            foreach(Supplier temp in list)
            {
                Console.WriteLine($"{temp.SupplierID}--{temp.SupplierName}--{temp.Address}--{temp.ContactNo}--{temp.Email}--{temp.CityOperatesIn}");
            }
        }
        public static void DisplayInventory()
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
                            InventoryId=Inventory.Id,
                            InventoryDetails=Inventory.Details,
                            InventoryLastUpdated=Inventory.LastUpdated,
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
    }
}