using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dsw2026Ej8
{
    partial class ProductHelper
    {
        public string FormatearPrecio (decimal precio)
        {
            return precio.ToString("C", new CultureInfo("es-AR"));
        }
    }
}
