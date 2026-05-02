using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    class WholeSale : Sale
    {
        public WholeSale (string descripcion, int cantidad, decimal precio) : base( descripcion, cantidad, precio)
        {
        }

        public override decimal CalculateTotal()
        {
            decimal total = base.CalculateTotal();
            return total * 0.90m ;
        }
    }
}
