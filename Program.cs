using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDiseno3D_S2
{
    internal class Program
    {
        static List<Figura> figuras = new List<Figura>();

        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 6)
            {
                Console.WriteLine("1. Agregar Rectangulo");
                Console.WriteLine("2. Agregar Cuadrado");
                Console.WriteLine("3. Agregar Circulo");
                Console.WriteLine("4. Agregar Triangulo");
                Console.WriteLine("5. Ver todas las figuras");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Base: ");
                    float baseRect = float.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    float altura = float.Parse(Console.ReadLine());

                    Rectangulo r = new Rectangulo(nombre, baseRect, altura);
                    figuras.Add(r);
                    Console.WriteLine("Rectangulo agregado");
                }
                else if (opcion == 2)
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Lado: ");
                    float lado = float.Parse(Console.ReadLine());

                    Cuadrado c = new Cuadrado(nombre, lado);
                    figuras.Add(c);
                    Console.WriteLine("Cuadrado agregado");
                }
                else if (opcion == 3)
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Radio: ");
                    float radio = float.Parse(Console.ReadLine());

                    Circle cir = new Circle(nombre, radio);
                    figuras.Add(cir);
                    Console.WriteLine("Circulo agregado");
                }
                else if (opcion == 4)
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Base: ");
                    float baseTri = float.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    float altura = float.Parse(Console.ReadLine());

                    Triangulo t = new Triangulo(nombre, baseTri, altura);
                    figuras.Add(t);
                    Console.WriteLine("Triangulo agregado");
                }
                else if (opcion == 5)
                {
                    for (int i = 0; i < figuras.Count; i++)
                    {
                        Console.WriteLine("Nombre: " + figuras[i].nombre);
                        Console.WriteLine("Area: " + figuras[i].Área());
                        Console.WriteLine("-------------------");
                    }
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("Adios");
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
            }
        }
    }
}