using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

//● El método de extensión debe:
//○ eliminar espacios al inicio y al final,
//○ convertir el texto a mayúsculas,
//○ reemplazar espacios internos por guiones.
//● Si el código es null, debe retornar "SIN-CODIGO".
//Ejemplo:
//" ab 123 x " => "AB-123-X


namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return "SIN-CODIGO";
            }

            //Eliminar espacios al inicio y al final
            string normalizado = codigo.Trim();

            //Convertir a mayúsculas
            normalizado = normalizado.ToUpper();

            // Reemplazar espacios internos por guiones
            normalizado = normalizado.Replace(" ", "-");

            return normalizado;
        }
    }
}
