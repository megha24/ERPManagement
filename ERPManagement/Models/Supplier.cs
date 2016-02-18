using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERPManagement.Models
{
    public class Supplier
    {
        [Key]
        private int id { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string address { get; set; }

        public Supplier(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }
    }
}