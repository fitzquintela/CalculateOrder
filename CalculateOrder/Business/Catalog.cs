using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOrder.Business
{
    internal class Catalog
    {
        internal Catalog()
        {
            Items = new Dictionary<string, CatalogItem>();
        }

        Dictionary<string, CatalogItem> Items;

        internal void AddItem(CatalogItem newItem)
        {
            CatalogItem existingItem = GetItem(newItem.ProductDesc);
            if (existingItem != null)
            {
                throw new Exception("Trying to add already existent product " + existingItem.ProductDesc + ".");
            }
            else
            {
                Items.Add(newItem.ProductDesc, newItem);
            }
        }

        internal CatalogItem GetItem(string productDesc)
        {
            if (Items.ContainsKey(productDesc))
            {
                return Items[productDesc];
            }
            else
            {
                return null;
            }
        }

        internal CatalogItem RemoveStock(string productDesc, int quantity)
        {
            CatalogItem itemToRemove = GetItem(productDesc);

            if (itemToRemove.ProductQuantity < quantity)
            {
                throw new CatalogException("Not enough quantity in stock for product " + productDesc + ".");
            }
            itemToRemove.ProductQuantity -= quantity;

            return itemToRemove;
        }
    }
}
