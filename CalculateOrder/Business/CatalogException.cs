using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOrder.Business
{
    internal class CatalogException: Exception
    {
        internal CatalogException(string message)
            : base(message)
        { }
    }
}
