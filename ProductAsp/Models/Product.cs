using System;
using System.ComponentModel.DataAnnotations;

namespace ProductAsp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int Price { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}