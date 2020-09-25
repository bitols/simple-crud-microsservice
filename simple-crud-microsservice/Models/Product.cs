using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud_microsservice.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal price { get; set; }
        public int categoryId { get; set; }
    }
}
