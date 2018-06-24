using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOrder.Business;

namespace CalculateOrder
{
    class Program
    {
        const int ERROR_OUT_OF_STOCK = 1;

        static void Main(string[] args)
        {
            if (args.Length < 3 || (args.Length - 1) % 2 != 0)
                return;

            try
            {
                string path = args[0];
                Catalog catalog = CatalogFileLoader.GetData(path);

                double orderPrice = Calculator.GetTotalPrice(catalog, args);

                Console.WriteLine("Total: " + orderPrice.ToString());
            }
            catch (CatalogException ce)
            {
                Console.WriteLine(ce.Message);
                Environment.ExitCode = ERROR_OUT_OF_STOCK;
            }
            catch
            {
            }
        }
    }
}
