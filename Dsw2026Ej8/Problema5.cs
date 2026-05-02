using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

//Crear un método público ObtenerImporteFinal, dentro de una clase Problema5, que
//reciba:
//● Sale sale
//Debe retornar un decimal.
//La clase base Sale debe tener un método virtual CalculateTotal.
//Deben existir al menos dos clases derivadas:
//● RetailSale
//● WholesaleSale
//Cada clase derivada debe redefinir el cálculo del total.
//Condiciones:
//● RetailSale retorna el importe sin descuento.
//● WholesaleSale aplica un descuento del 10%.
//● El método ObtenerImporteFinal debe llamar a sale.CalculateTotal().
//● La resolución debe demostrar que se ejecuta el método correspondiente según el
//tipo real del objeto recibido.

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal (Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}
