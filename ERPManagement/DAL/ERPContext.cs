using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ERPManagement.Models;

namespace ERPManagement.DAL
{
    public class ERPContext : DbContext
    {
        public ERPContext():base("name=erpManagement")
        {
            
        }

        public DbSet<Item> Items { get; set; }
    }
}