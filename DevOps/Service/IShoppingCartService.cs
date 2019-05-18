using DevOps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOps.Service
{
      public  interface IShoppingCartService
    {
        IEnumerable<ShoppingItem> GetAllItems();
        ShoppingItem Add(ShoppingItem newItem);
        ShoppingItem GetById(Guid id);
        void Remove(Guid id);
    }
}
