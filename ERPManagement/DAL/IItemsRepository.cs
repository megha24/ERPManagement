using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERPManagement.Models;

namespace ERPManagement.DAL
{
    public interface IItemsRepository: IDisposable
    {
        IEnumerable<Item> GetItems();
        
    }
}