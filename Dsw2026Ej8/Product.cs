using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        string nombre;
        long codigo;
        string descripcion;

        public Product(long codigo, string nombreProd, string descripcion)
        {
            this.nombre = nombreProd;
            this.codigo = codigo;
            this.descripcion = descripcion;
        }

        public string ModificarDescripcion(string modificacion)
        {
            this.descripcion = modificacion;
            return this.descripcion;
        }

    }
}
