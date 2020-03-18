using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            //TestPerson();
            //TestOneToMany();
            //OneToManyFromKeyboard();
            TestManyToMany();

        }

        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person p = PersonFromKeyboard();
                context.People.Add(p);
                context.SaveChanges();

                var items = context.People;
                foreach (var x in items)
                {
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
                }
            }
        }

        static Person PersonFromKeyboard()
        {
            string firstName;
            string lastName;
            string middleName;
            string telephoneNumber;

            Console.WriteLine("--Using keyboard to create people");
            Console.WriteLine("--Give me a FirstName:");
            firstName = Console.ReadLine();
            Console.WriteLine("--Give me a LastName:");
            lastName = Console.ReadLine();
            Console.WriteLine("--Give me a MiddleName:");
            middleName = Console.ReadLine();
            Console.WriteLine("--Give me a TelephoneNumber:");
            telephoneNumber = Console.ReadLine();

            return new Person
            { 
                FirstName = firstName, 
                LastName = lastName, 
                MiddleName = middleName, 
                TelephoneNumber = telephoneNumber 
            };
        }

        static void TestOneToMany()
        {
            Console.WriteLine("One to many association");
            using (ModelOneToManyContainer context = new ModelOneToManyContainer())
            {
                Customer c = new Customer()
                {
                    Name = "Customer 1",
                    City = "Iasi"
                };
                Order o1 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = 300,
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }

        static void OneToManyFromKeyboard()
        {
            using (ModelOneToManyContainer context = new ModelOneToManyContainer())
            {
                while (true)
                {
                    Console.WriteLine("--What would you like to enter into the database? 1 for customer, 2 for order--");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Customer c = CustomerFromKeyboard();
                        context.Customers.Add(c);
                        context.SaveChanges();
                        var customers = context.Customers;
                        foreach (Customer x in customers)
                            Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("--Do you have a customer for your order? y/n--");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "y")
                        {
                            Console.WriteLine("--Enter the customer's Id--");
                            Customer customer = null;
                            int customerId = Convert.ToInt32(Console.ReadLine());

                            var customers = context.Customers;
                            foreach (Customer c in customers)
                                if (c.CustomerId == customerId)
                                    customer = c;
                            if (customer == null)
                            {
                                Console.WriteLine("--Customer not found--");
                                return;
                            }

                            Order o = OrderFromKeyboard(customer);
                            context.Orders.Add(o);
                            context.SaveChanges();
                        }
                        else if (choice2 == "n")
                        {
                            Customer c = CustomerFromKeyboard();
                            Order o = OrderFromKeyboard(c);

                            context.Customers.Add(c);
                            context.Orders.Add(o);
                            context.SaveChanges();
                        }
                    }
                    var items = context.Customers;
                    foreach (var x in items)
                    {
                        Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);
                        foreach (var ox in x.Orders)
                            Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue);
                    }
                }
                
            }
        }

        static Customer CustomerFromKeyboard()
        {
            Console.WriteLine("--Input Customer's details--");
            Console.WriteLine("Enter customer name");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter customer city");
            string customerCity = Console.ReadLine();
            Customer c = new Customer()
            {
                Name = customerName,
                City = customerCity
            };
            return c;
        }
        
        static Order OrderFromKeyboard(Customer c)
        {
            Console.WriteLine("--Input Order's details--");
            Console.WriteLine("Enter order's total value");
            string orderValue = Console.ReadLine();
            decimal decimalValue = Convert.ToDecimal(orderValue);

            Order o = new Order()
            {
                TotalValue = decimalValue,
                Date = DateTime.Now,
                Customer = c
            };
            return o;
        }

        static void TestManyToMany()
        {
            Console.WriteLine("Many to many association");
            using(ModelManyToManyContainer context = new ModelManyToManyContainer())
            {
                Album al1 = new Album()
                {
                    AlbumName = "The Wall (1979)"
                };
                Artist ar1 = new Artist()
                {
                    FirstName = "John",
                    LastName = "Cena",
                    Albums = new List<Album> { al1 }
                };
                Artist ar2 = new Artist()
                {
                    FirstName = "Johnny",
                    LastName = "Sins"
                };
                Album al2 = new Album()
                {
                    AlbumName = "You can't see me",
                    Artists = new List<Artist>() { ar1, ar2 }
                };

                context.Albums.Add(al1);
                context.Artists.Add(ar1);
                context.Artists.Add(ar2);
                context.Albums.Add(al2);
                context.SaveChanges();


                var artists = context.Artists;
                foreach (var a in artists)
                {
                    Console.WriteLine("Artist : {0}, {1}, {2}", a.ArtistId, a.FirstName, a.LastName);
                    foreach (var al in a.Albums)
                        Console.WriteLine("\tAlbums: {0}, {1}", al.AlbumId, al.AlbumName);
                }
            }
        }

    }
}
