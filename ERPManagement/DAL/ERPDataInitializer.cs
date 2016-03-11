using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERPManagement.Models;

namespace ERPManagement.DAL
{
    public class ERPDataInitializer: System.Data.Entity.CreateDatabaseIfNotExists<ERPContext>
    {
        protected override void Seed(ERPContext context)
        {
            var items = new List<Item>
            {
                new Item(1, "item1", "quality1"),
                new Item(2, "item2", "quality2"),
                new Item(3, "item3", "quality3")
            };
            items.ForEach(i=> context.Items.Add(i));
            context.SaveChanges();
        }
    }
}