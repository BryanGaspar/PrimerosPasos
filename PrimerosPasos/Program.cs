using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datps
            int a, b, suma; //Variable tipo entero
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {0} + {1} = {2}", a, b, suma);
            // flotante
            int sueldo, egreso, total;
            Console.WriteLine("ingresa el sueldo del trabajador: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el egreso del trabajador: ");
            egreso = int.Parse(Console.ReadLine());
            total = calcularSueldo(sueldo,egreso);
            Console.WriteLine("el liquido a recibir es: {0} ", total);
            // double
            double x1 = 200.5679;
            Console.WriteLine("Tipo de dato double: {0}", x1);
            //tipo de dato: cadena de caracteres (string)
            String nombre;
            Console.WriteLine("Ingresatu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("hola " + nombre + " Bienvenido al curso de programacion ");
            //booleanos
            bool sw;
            sw = (a + 50) > b;
            Console.WriteLine("El Valor de boll sw: {0}", sw);

            // pilares fundamentales
            // ejecucion de sentencias secuenciales
            // uso de estructuras repetitivas y selectivas
            // 
            saludos(nombre);
            saludos("EteSech");
            Console.ReadKey();
            //funciones: subprocesos - subprogramas - subrutinas
            //dividir el codigo en pequeños modulos
            //reutilizar codigo
            //Tipo: devuelven valores - no devuelve valores

        }
        static void saludos(String nombre) //Parametros - Argumentos
        {
            Console.Write("Funcion que no devuelve valores.....");
            Console.Write("Hola {0} ", nombre);
        }
        //Funcion que devuelve un tipo de dato
        static int calcularSueldo(int ingreso, int egreso)
        {
            return (ingreso-egreso);
        }
    }
  

}
