using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud_microsservice.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        [Column(TypeName = "decimal(18,4)")]

        public decimal price { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [ForeignKey("categoryId")]
        public Category category{get;set;}
                
        public int categoryId { get; set; }
    }
}
