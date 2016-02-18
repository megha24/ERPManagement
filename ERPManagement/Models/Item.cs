﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERPManagement.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(100)]
        public string quality { get; set; }
    }
}