using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ERPManagement.Models;

namespace ERPManagement.DAL
{
    public class ItemStore : DbContext
    {
        public ItemStore():base("name=erpManagementConnectionString")
        {
            
        }

        public DbSet<Item> GetItems { get; set; }
    }
}