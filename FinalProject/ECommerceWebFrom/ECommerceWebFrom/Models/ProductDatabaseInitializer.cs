using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ECommerceWebFrom.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Ipads and Tablets"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Computers"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Cell Phones"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Batteries"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Accessories"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Apple Ipad",
                    Description = "Apple iPad mini 2 16GB WiFi, 7.9 Retina display, A7 chip with M7 motion coprocessor, Front and Back cameras",
                    ImagePath="Apple-Ipad.jpg",
                    UnitPrice = 199.00,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Rca Viking Pro",
                    Description = "2-in-1 Tablet 32GB Quad Core, 1.3GHz Quad-Core processor, Google Android 5.0 (Lollipop) OS Webcams, Wi-Fi and Bluetooth.",
                    ImagePath="Rca-Viking-Pro.jpg",
                    UnitPrice = 79.99,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Epic Learning",
                    Description = "7.0 touchscreen, 1.2GHz Intel Quad-Core processor, Google Android 5.0 (Lollipop) OS",
                    ImagePath="Epic-Learning.jpg",
                    UnitPrice = 69.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "RCA Tablet",
                    Description = "16GB Quad Core includes Keyboard / Case, 1.3GHz Quad-Core processor, 16GB of storage memory",
                    ImagePath="RCA-Tablet.jpg",
                    UnitPrice = 49.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "NextBook Flexx",
                    Description = "2-in-1 Tablet 32GB Intel Quad Core, 1.83GHz Intel Atom Z3735G Quad-Core processor, 32GB of storage memory.",
                    ImagePath="Nextbook-Flexx.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "HP Black 15.6",
                    Description = "15-f211wm Laptop PC with Intel Celeron N2840 Processor, 4GB Memory, Touchscreen, 500GB Hard Drive and Windows 10 Home.",
                    ImagePath="HP-Black.jpg",
                    UnitPrice = 299.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Lenovo Black 11.6 ",
                    Description = "N21 Chromebook PC with Intel Celeron N2840 Dual-Core Processor, 2GB Memory, 16GB Solid State Drive and Chrome OS.",
                    ImagePath="Lenovo-Black.jpg",
                    UnitPrice = 176.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Lenovo Black 15.6",
                    Description = "IdeaPad 100 Laptop PC with Intel Core i5-5200U Processor, 6GB Memory,1TB Hard Drive and Windows 10.",
                    ImagePath="Lenovo-Black-2.jpg",
                    UnitPrice = 477.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Acer Black ",
                    Description = "Veriton Z All-in-One Desktop PC with Intel Core i3-4150T Dual-Core Processor, 4GB Memory, 19.5 Monitor, 500GB Hard Drive and Windows 7 Professional.",
                    ImagePath="Acer-Black.jpg",
                    UnitPrice = 661.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Lenovo Black 17.3",
                    Description = "Z70 80FG0036US Laptop PC with Intel Core i5-5200U Processor, 8GB Memory, 1TB Hard Drive and Windows 8.1.",
                    ImagePath="Lenovo-Black-3.jpg",
                    UnitPrice = 770.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "iPhone 5S 4G",
                    Description = "LTE 16GB Prepaid Smartphone, Prepaid smartphone, 8-megapixel iSight camera for photos and 1080p HD video recording, FaceTime HD camera for video calls.",
                    ImagePath="Iphone-5s.jpg",
                    UnitPrice = 299.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Samsung Galaxy S4",
                    Description = "Prepaid Smartphone, 1.9GHz quad-core processor, 13MP rear-facing camera.",
                    ImagePath="Samsung-Galaxy-S4.jpg",
                    UnitPrice = 249.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Samsung Galaxy",
                    Description = "Core Prime Prepaid Smartphone, Android 5.1 (Lollipop) OS, Talk time: up to 20 h",
                    ImagePath="Samsung-Galaxy.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Duracell 30 AA",
                    Description = "Copper Top Alkaline Long Lasting Batteries 2021/2022. Get dependable, long-lasting power from CopperTop batteries with Duralock Power Preserve Technology..",
                    ImagePath="Duracell.jpg",
                    UnitPrice = 17.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Duracell 60 AA",
                    Description = "Get dependable, long-lasting power from CopperTop batteries with Duralock Power Preserve Technology. These batteries have been engineered to deliver just the right level of power for most of your household needs. Plus, they now have up to a 10-year guarantee in storage. ",
                    ImagePath="Duracell-2.jpg",
                    UnitPrice = 29.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Skullcandy Hesh 2 W",
                    Description = "Compatible with any Bluetooth-enabled device, Supreme Sound technology, Up to 15 hours play time on built-in rechargeable battery.",
                    ImagePath="Skullcandy.jpg",
                    UnitPrice = 90.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}