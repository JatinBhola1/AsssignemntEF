using DAL.Context;

using BusinessObject.Models;

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
                                            BAL.Class1 ball = new BAL.Class1();
                                            Supplier supplier = new Supplier()
                                            {
                                                SupplierName = "Ajay",
                                                Address = "New Delhi",
                                                ContactNo = "9910199101",
                                                Email = "hdkjdwcn@gmail.com",
                                                CityOperatesIn = "Delhi"
                                            };
                                            ball.AddSupplier(supplier);
                                            Console.WriteLine("Supplier succesfully Added");
                                            break;
                                        }
                                    case 2:
                                        {
                                            BAL.Class1 ball = new BAL.Class1();
                                            Supplier supplier = new Supplier();
                                            ball.DeleteSupplier(4, supplier);
                                            Console.WriteLine("Supplier succesfully Deleted");
                                            break;
                                        }
                                    case 3:
                                        {
                                            BAL.Class1 ball = new BAL.Class1();
                                            Supplier supplier = new Supplier()
                                            {
                                                SupplierName = "Ashok",
                                                Address = "New Delhi",
                                                ContactNo = "9910199101",
                                                Email = "hdkjdwcn@gmail.com",
                                                CityOperatesIn = "Delhi"
                                            };
                                            ball.EditSupplier(3, supplier);
                                            Console.WriteLine("Supplier succesfully Edited");
                                            break;
                                        }
                                    case 4:
                                        {
                                            BAL.Class1 ball = new BAL.Class1();
                                            Supplier supplier = new Supplier();
                                            ball.DisplaySupplier(supplier);
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
                                            Console.WriteLine("Enter the Supplier Id");
                                            int id = byte.Parse(Console.ReadLine());
                                            BAL.Class1 ball = new BAL.Class1();

                                            Inventory inventory = new Inventory()
                                            {
                                                Name = "pen",
                                                Details = "good pen",
                                                QtyInStock = 50,
                                                LastUpdated = Convert.ToDateTime("12/12/2022"),
                                                

                                            };
                                            ball.AddInventory(id, inventory);

                                            Console.WriteLine("inventory succesfully added");
                                            break;
                                        }
                                    case 2:
                                        {
                                            BAL.Class1 ball = new BAL.Class1();
                                            Inventory inventory = new Inventory();
                                            ball.DeleteInventory(1, inventory);
                                            Console.WriteLine("Inventory Succesfully Deleted");
                                            break;
                                        }
                                    case 3:
                                        {
                                            BAL.Class1 ball = new BAL.Class1();
                                            Inventory inventory = new Inventory();
                                            ball.EditInventory(2, inventory);
                                            
                                            Console.WriteLine("Inventory Succesfully Edited");
                                            break;
                                        }
                                    case 4:
                                        {
                                            BAL.Class1 ball = new BAL.Class1();
                                            Inventory inventory= new Inventory();
                                            ball.DisplayInventory(inventory);
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
      
       
        
    }
}