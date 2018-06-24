using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOrder.Business
{
    internal class CatalogFileLoader
    {
        internal static Catalog GetData(string path)
        {
            Catalog loadedCatalog = new Catalog();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    CatalogItem catalogItem = GetCatalogItem(line);
                    loadedCatalog.AddItem(catalogItem);
                }
            }
            return loadedCatalog;
        }

        private static CatalogItem GetCatalogItem(string line)
        {
            var values = line.Split(',');
            string productDesc = values[0];
            int productQuantity = int.Parse(values[1]);
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            double productValue = double.Parse(values[2], culture);
            var catalogItem = new CatalogItem(productDesc, productQuantity, productValue);
            return catalogItem;
        }
    }
}
