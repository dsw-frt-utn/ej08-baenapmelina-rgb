using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
     class RetailSale : Sale
    {
        public RetailSale(string descripcion, int cantidad, decimal precio) : base(descripcion, cantidad, precio)
        {

        }

        public override decimal CalculateTotal()
        {
            return base.CalculateTotal();
        }
    }
}
