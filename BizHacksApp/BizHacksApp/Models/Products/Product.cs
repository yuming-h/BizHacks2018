using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BizHacksApp.Models.Products
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Audio { get; set; }
        public string ProcessorType { get; set; }
        public double? ProcessorSpeed { get; set; }
        public int? RamSize { get; set; }
        public int? HardDiskSpace { get; set; }
        public string GraphicsCard { get; set; }
        public int? GPUMemory { get; set; }
        public double? GPUSpeed { get; set; }
        public double Price { get; set; }
    }
}