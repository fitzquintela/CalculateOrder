using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOrder.Business
{
    internal class Calculator
    {
        internal static double GetTotalPrice(Catalog catalog, params string[] args)
        {
            const double vat = 0.23;

            double total = 0;

            for(int i=1; i<args.Length; i+=2)
            {
                string orderProductDesc = args[i];
                int orderProductQuantity = int.Parse(args[i + 1]);

                CatalogItem catalogItem = catalog.RemoveStock(orderProductDesc, orderProductQuantity);

                total += catalogItem.ProductPrice * orderProductQuantity;
            }

            return total * (1 + vat);
        }
    }
}
