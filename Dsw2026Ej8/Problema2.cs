using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;


//Crear un método público CrearResumenVenta, dentro de una clase Problema2, que
//reciba:
//● long productCode
//● string productDescription
//● int quantity
//● decimal unitPrice
//El método debe crear internamente una clase anónima con los datos:
//● Code
//● Description
//● Quantity
//● Total
//Debe retornar una cadena con el formato:
//Code - Description - Total
//Condiciones:
//● Total debe calcularse como quantity * unitPrice.
//● Si quantity es menor o igual a 0, el total debe ser 0.
//● El método debe usar una clase anónima dentro de su implementación.


namespace Dsw2026Ej8
{
    internal class Problema2
    {
       
        public string CrearResumenVenta(long codigoProducto, string descripcionProducto, int cantidad, decimal precioUnitario)
        {
            decimal total = 0;
            if (cantidad > 0) total = cantidad * precioUnitario;
            else total = 0;

            var anonima = new { Code = codigoProducto, Description = descripcionProducto, Quantity = cantidad, Total = total };

            string mensaje = $"{anonima.Code} - {anonima.Description} - {anonima.Total}";

            return mensaje;
        }
    }
}
