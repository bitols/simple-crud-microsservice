using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud_microsservice.Models
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }

        public string name { get; set; }

        public string description { get; set; }
    }
}
