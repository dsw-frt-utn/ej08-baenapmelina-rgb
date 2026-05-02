using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

//Crear un método público CalcularPromedio, dentro de una clase Problema4, que
//reciba:
//● int? nota1
//● int? nota2
//● int? nota3
//Debe retornar un double.
//Condiciones:
//● Debe calcular el promedio solo con las notas que tengan valor.
//● Si las tres notas son null, debe retornar 0.
//● Si una nota tiene valor menor que 0 o mayor que 10, debe ignorarse.
//● No debe lanzar excepción si alguna nota es null.

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int sumaNotas = 0;
            int contador = 0;

            if (nota1.HasValue && nota1 >= 0 && nota1 <= 10)
            {
                sumaNotas += (int)nota1;
                contador++;
            }
            if (nota2.HasValue && nota2 >= 0 && nota2 <= 10)
            {
                sumaNotas += (int)nota2;
                contador++;
            }
            if (nota3.HasValue && nota3 >= 0 && nota3 <= 10)
            {
                sumaNotas += (int)nota3;
                contador++;
            }

            if (contador == 0)
            {
                return 0;
            }
            else
            {
                double promedio = (double)sumaNotas / contador;
                return promedio;
            }

        }
    }
}
