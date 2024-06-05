namespace BO
{
    public class ApplicationDbContext
    {
        public List<Warehouse> Warehouses = new List<Warehouse>()
                {
                    new Warehouse()
                    {
                        Id = 1,
                        Name = "Entrepot de Paris",
                        Address = "10 rue du csharp",
                        PostalCode = 75000,
                        CodeAccesMD5 = new()
                        {
                            "840e998a22948adf5de39bd4f2b35da7",
                            "74b87337454200d4d33f80c4663dc5e5",
                        },

                    }
        };

       public List<Article> ArticleReferences { get; set; } =
             new List<Article>() {
                new Article
                {
                    Id = 1,
                    Name = "Ordinateur Portable",
                    Description = "Ordinateur portable haute performance",
                    Price = 1200.00m,
                    StockQuantity = 50
                },
                new Article
                {
                    Id = 2,
                    Name = "Smartphone",
                    Description = "Smartphone avec écran AMOLED",
                    Price = 800.00m,
                    StockQuantity = 100
                },
                new Article
                {
                    Id = 3,
                    Name = "Tablette",
                    Description = "Tablette 10 pouces avec stylet",
                    Price = 600.00m,
                    StockQuantity = 30
                }
        };
        public List<Order> Orders { get; set; } = new List<Order>()
        {
                new Order
                  {
                        Id = 1,
                        WarehouseId = 1,
                        CustomerName = "John Doe",
                        Email = "johndoe@example.com",
                        ShippingAddress = "123 Main Street",
                        OrderDate = DateTime.Now,
                        TotalAmount = 2000.00,
                        OrderStatus = "Processing"
                },
               new Order
              {
                    Id = 2,
                    WarehouseId = 1,
                    CustomerName = "John Doe",
                    Email = "bill.gate@example.com",
                    ShippingAddress = "One Microsoft Way",
                    OrderDate = DateTime.Now,
                    TotalAmount = 2000.00,
                    OrderStatus = "Processing"
            }
        };
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>()
        {
                new() {
                    OrderId = 1,
                    ArticleId = 2,
                    Quantity = 1,
                    UnitPrice = 1200.00m
                },
                new() {
                    OrderId =1,
                    ArticleId = 2,
                    Quantity = 1,
                    UnitPrice = 800.00m
                },
                new() {
                    OrderId =2,
                    ArticleId = 3,
                    Quantity = 1,
                    UnitPrice = 800.00m
                }
        };
    }
}
