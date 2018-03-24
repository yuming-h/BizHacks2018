using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BizHacksApp.Models.Products;

namespace BizHacksApp.Data
{
    public class DummyData
    {
        public static List<Product> getProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    ProductName = "Razor Edge Gaming Laptop",
                    Category = "Laptop",
                    Audio = "Built-in Speakers, Headphone Jack",
                    ProcessorType = "Intel i7-7550",
                    ProcessorSpeed = 2.5,
                    RamSize = 4,
                    HardDiskSpace = 500,
                    GraphicsCard = "GTX 750Ti",
                    GPUMemory = 4,
                    GPUSpeed = 1.5,
                    Price = 1699.99
                },
                new Product()
                {
                    ProductName = "Alienware Gaming Laptop",
                    Category = "Laptop",
                    Audio = "Built-in Speakers",
                    ProcessorType = "Intel i7-7690i",
                    ProcessorSpeed = 3.0,
                    RamSize = 8,
                    HardDiskSpace = 1000,
                    GraphicsCard = "GTX 1060Ti",
                    GPUMemory = 8,
                    GPUSpeed = 2.1,
                    Price = 2599.99
                },
            };

            return products;
        }
    }
}