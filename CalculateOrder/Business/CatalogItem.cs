using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOrder.Business
{
    internal class CatalogItem
    {
        internal CatalogItem(string productDesc, int productQuantity, double productPrice)
        {
            ProductDesc = productDesc;
            ProductQuantity = productQuantity;
            ProductPrice = productPrice;
        }

        internal string ProductDesc { get; set; }
        internal int ProductQuantity { get; set; }
        internal double ProductPrice { get; set; }
    }
}
