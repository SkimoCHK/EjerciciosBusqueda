using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBusqueda.Clases
{
    public class Ejercicios
    {
        public void BusquedaNumero(int numero)
        {
            int[] array1 = { 5, 200, 400, 4, 20, 35, 43, 2, 55, 90, 665, 243, 25, 12 };
            bool encontrado = false; 
            int contador = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (numero == array1[i])
                {
                    Console.WriteLine($"El número que pediste encontrar se encuentra en la posición {contador} del arreglo");
                    encontrado = true;
                    break;
                }

                contador++;
            }

            if (!encontrado)
            {
                Console.WriteLine("El número no existe en la matriz");
            }
        }

        public void BusquedaCadena(string texto)
        {
            string[] array1 = { "manzana", "banana", "pera", "uva", "naranja", "piña" };
            bool encontrado = false;
            int contador = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (texto == array1[i])
                {
                    Console.WriteLine($"La cadena que pediste encontrar se encuentra en la posición {contador} del arreglo");
                    encontrado = true;
                    break;
                }

                contador++;
            }

            if (!encontrado)
            {
                Console.WriteLine("La cadena no existe en la matriz");
            }
        }

        public void BusquedaNumeroPar()
        {
            int[] array1 = { 3, 7, 1, 5, 8, 10, 4, 9, 6 };
            bool encontrado = false;
            int contador = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    Console.WriteLine($"El primer número par se encuentra en la posición {contador} del arreglo.");
                    encontrado = true;
                    break;
                }

                contador++;
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron números pares en el arreglo.");
            }
        }


        public void BuscarNumerosPares()
        {
            int[] array1 = { 3, 7, 1, 5, 8, 10, 4, 9, 6 };

            Console.WriteLine("Posiciones de los numeros pares en el arreglo:");

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    Console.WriteLine($"Numero par encontrado en la posición {i}");
                }
            }
        }

        public void BusquedaBinaria()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.Write("Ingresa el nuumero que deseas buscar: ");
            int numeroABuscar = int.Parse(Console.ReadLine());

            int inicio = 0;
            int final = array1.Length - 1;
            int encontradoEn = -1;

            while (inicio <= final)
            {
                int medio = (inicio + final) / 2;

                if (array1[medio] == numeroABuscar)
                {
                    encontradoEn = medio;
                    break;
                }
                else if (array1[medio] < numeroABuscar)
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }
            }

            if (encontradoEn != -1)
            {
                Console.WriteLine($"El número {numeroABuscar} se encuentra en la posición {encontradoEn} del arreglo.");
            }
            else
            {
                Console.WriteLine($"El número {numeroABuscar} no está en el arreglo.");
            }
        }

        public void BusquedaBinariaCadena()
        {
            string[] frutas = { "banana", "cereza", "fresa", "limón", "manzana", "naranja", "uva" };

            Console.Write("Ingresa la cadena que deseas buscar: ");
            string cadenaABuscar = Console.ReadLine().ToLower(); 

            int inicio = 0;
            int final = frutas.Length - 1;
            int encontradoEn = -1;

            while (inicio <= final)
            {
                int medio = (inicio + final) / 2;
                string cadenaMedia = frutas[medio].ToLower();

                int comparacion = string.Compare(cadenaMedia, cadenaABuscar);

                if (comparacion == 0)
                {
                    encontradoEn = medio;
                    break;
                }
                else if (comparacion < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }
            }

            if (encontradoEn != -1)
            {
                Console.WriteLine($"La cadena '{cadenaABuscar}' se encuentra en la posición {encontradoEn} del arreglo.");
            }
            else
            {
                Console.WriteLine($"La cadena '{cadenaABuscar}' no está en el arreglo.");
            }
        }




    }
}
