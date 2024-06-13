using Ex07_EntityFramework.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        DisplayAllArticles();
    }


    private static void InsertDefaultData()
    {
        using (var context = new ApplicationDbContext())
        {
            var warehouse = new Warehouse
            {
                Name = "Entrepot de Paris",
                Address = "10 rue du csharp",
                PostalCode = 75000,
                CodeAccesMD5 = new List<string>
                        {
                             "840e998a22948adf5de39bd4f2b35da7" ,
                           "74b87337454200d4d33f80c4663dc5e5" 
                        }
            };

            var articles = new List<Article>
                    {
                        new Article { Name = "Ordinateur Portable", Description = "Ordinateur portable haute performance", Price = 1200.00m, StockQuantity = 50 },
                        new Article { Name = "Smartphone", Description = "Smartphone avec écran AMOLED", Price = 800.00m, StockQuantity = 100 },
                        new Article { Name = "Tablette", Description = "Tablette 10 pouces avec stylet", Price = 600.00m, StockQuantity = 30 }
                    };

            var orders = new List<Order>
                    {
                        new Order
                        {
                            Warehouse = warehouse,
                            CustomerName = "John Doe",
                            Email = "johndoe@example.com",
                            ShippingAddress = "123 Main Street",
                            OrderDate = DateTime.Now,
                            TotalAmount = 2000.00d,
                            OrderStatus = "Processing",
                            OrderDetails = new List<OrderDetail>
                            {
                                new OrderDetail { Article = articles[1], Quantity = 1, UnitPrice = 1200.00m },
                                new OrderDetail { Article = articles[1], Quantity = 1, UnitPrice = 800.00m }
                            }
                        },
                        new Order
                        {
                            Warehouse = warehouse,
                            CustomerName = "Bill Gate",
                            Email = "bill.gate@example.com",
                            ShippingAddress = "One Microsoft Way",
                            OrderDate = DateTime.Now,
                            TotalAmount = 2000.00d,
                            OrderStatus = "Processing",
                            OrderDetails = new List<OrderDetail>
                            {
                                new OrderDetail { Article = articles[2], Quantity = 1, UnitPrice = 800.00m }
                            }
                        }
                    };

            context.Warehouses.Add(warehouse);
            context.Articles.AddRange(articles);
            context.Orders.AddRange(orders);
            context.SaveChanges();
        }
    }

    static void DisplayAllArticles()
    {
        using (var context = new ApplicationDbContext())
        {
            var articles = context.Articles.ToList();
            foreach (var article in articles)
            {
                Console.WriteLine($"ID: {article.Id}, Name: {article.Name}, Price: {article.Price}, NbStock: {article.StockQuantity}");
            }
        }
    }
}