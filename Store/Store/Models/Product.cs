using System;
namespace Store.Models
{
    public class Product
    {   
        public long Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public string Category { get; set; }
        public bool InStock { get; set; }
    }
}
