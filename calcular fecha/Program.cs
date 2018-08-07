using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombre del Autor: Mauricio Mejia Estevez
            //Fecha: 10 Noviembre 2015
            //Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi
            //trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
            //2. Escribir un programa para calcular la fecha del siguiente día a partir de una fecha digitada
            // desde el teclado por el usuario ( dd, mm, aaaa ) e imprimirla. (Tenga en cuenta los años bisiestos.).
            int a, x_siguiente, dia;
            int dia_siguiente, mes, mes_siguiente;
            Console.Write("Ingrese el valor de dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de año: ");
            a = int.Parse(Console.ReadLine());
            if ((dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 29 && mes ==
            2) || (dia > 28 && mes == 2 && ((a % 4 != 0) || (a % 100) == 0) && (a % 400) != 0) || (dia >
            31))
            {
                Console.WriteLine(" Usted Dijito Valores No Validos ");
            }
            else
            {
                if ((dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia == 29 && mes
                == 2) || (dia == 28 && mes == 2 && ((a % 4 != 0) || (a % 100) == 0) && (a % 400) != 0) ||
                (dia == 31))
                {
                    dia_siguiente = 0;
                    mes_siguiente = mes + 1;
                }
                else
                {
                    dia_siguiente = dia + 1;
                    mes_siguiente = mes;
                }
                if (dia_siguiente == 0 && mes_siguiente == 0)
                {
                    mes_siguiente = 0;
                    x_siguiente = a + 1;
                }
                else
                    x_siguiente = a;
                Console.WriteLine(" Valor de dia siguiente : " + dia_siguiente);
                Console.WriteLine(" Valor de mes siguiente : " + mes_siguiente);
                Console.WriteLine(" Valor de año siguiente : " + x_siguiente);
            }
            Console.ReadKey();
        }
    }
}