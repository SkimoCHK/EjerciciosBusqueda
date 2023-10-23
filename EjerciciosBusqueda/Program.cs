using EjerciciosBusqueda.Clases;
using System;

namespace EjerciciosBusqueda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();
            Console.WriteLine("¿Que problema desea resolver?");
            Console.WriteLine("1. Buscar nnmero en arreglo");
            Console.WriteLine("2. Buscar cadena en arreglo");
            Console.WriteLine("3. Buscar numero par en arreglo");
            Console.WriteLine("4. Buscar posiciones de numeros pares en arreglo");
            Console.WriteLine("5. Busqueda binaria de numero en arreglo");
            Console.WriteLine("6. Busqueda binaria de cadena en arreglo");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa un numero para buscar en el arreglo: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    ejercicios.BusquedaNumero(numero);
                    break;
                case 2:
                    Console.Write("Escribe el nombre de una fruta para verificar si existe en el arreglo");
                    string fruta = Console.ReadLine();
                    ejercicios.BusquedaCadena(fruta);
                    break;
                case 3:
                    ejercicios.BusquedaNumeroPar();
                    break;
                case 4:
                    ejercicios.BuscarNumerosPares();
                    break;
                case 5:
                    ejercicios.BusquedaBinaria();
                    break;
                case 6:
                    ejercicios.BusquedaBinariaCadena();
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }
    }
}
