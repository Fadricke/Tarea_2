using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0; 
            do
            {
                Console.WriteLine("-----Bienvenido-----");
                Console.WriteLine("1- Ejercicio1");
                Console.WriteLine("2- Ejercicio2");
                Console.WriteLine("3- Ejercicio3");
                Console.WriteLine("4- Salir");
                Console.WriteLine("---------------------");
                Console.WriteLine("Ingrese su opcion");
                opcion=int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Ejercicio1();
                        break;
                    case 2: Ejercicio2();
                        break;
                    case 3:  Ejercicio3();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opcion valida");  
                        Console.ReadLine();
                        break;

                }
            } while (opcion != 4);

            Console.ReadLine();
        }
        static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");
            int cantidad = 0;
            float precio = 0; 

            Console.WriteLine("Digite la cantidad"); cantidad = int .Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio"); precio = int.Parse(Console.ReadLine());
            if (cantidad > +2 && cantidad <= 5)
                Console.WriteLine($"El precio de las camisas es de {(cantidad * precio) * 0.85f} con un descuento de 15%");
            else if (cantidad>5)
                Console.WriteLine($"El precio de las camisas es de {(cantidad * precio) * 0.8f} con un descuento de 20%");
            else 
                Console.WriteLine($"El precio de las camisas es de {cantidad * precio}");
        }
        static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");

            string nombre, carnet,condicion;
            float quiz1, quiz2, quiz3, tarea1, tarea2, tarea3, examen1, examen2, examen3;
            Console.WriteLine("Ingrese los siguientes datos:");
            Console.WriteLine("Carné"); carnet = Console.ReadLine();
            Console.WriteLine("Nombre"); nombre = Console.ReadLine();
            Console.WriteLine("Quiz 1"); quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quiz 2"); quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quiz 3"); quiz3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Tarea 1"); tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Tarea 2"); tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Tarea 3"); tarea3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Examen 1"); examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Examen 2"); examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Examen 3"); examen3 = float.Parse(Console.ReadLine());

            double porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25f; porcentajeQuices=Math.Round(porcentajeQuices, 2);
            double porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.30f; porcentajeTareas = Math.Round(porcentajeTareas, 2);
            double porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * 0.45f; porcentajeExamenes = Math.Round(porcentajeExamenes, 2);

            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;
            promedioFinal = Math.Round(promedioFinal, 2);

            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de quices: " + porcentajeQuices);
            Console.WriteLine("Porcentaje de tareas: " + porcentajeTareas);
            Console.WriteLine("Porcentaje de exámenes: " + porcentajeExamenes);
            Console.WriteLine("Promedio final: " + promedioFinal);
            Console.WriteLine("Condición: " + condicion);
        }
        static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Ingrese la cantidad de articulos: ");
            int cantidad = int.Parse(Console.ReadLine());

            double precioXarticulo;

            if (cantidad <= 10){
                precioXarticulo = 20.0; }
            else {
                precioXarticulo = 15.0; }

            double total = cantidad * precioXarticulo;

            Console.WriteLine($"El preciuo por articulo es: ${precioXarticulo}");
            Console.WriteLine($"El total a pagar es de: ${total}");
        }
    }
}
