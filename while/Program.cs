using System;

class Program
{
    static void Main()
    {
        string nombre, apellido, respuesta = "s";
      //  bool continuar;

      //  do
      //  {

               while (respuesta == "s")
            {
                Console.WriteLine("Ingrese su nombre: \n");
                nombre = Console.ReadLine().Trim();

                Console.WriteLine("Ingrese su apellido: \n");
                apellido = Console.ReadLine().Trim();

                Console.WriteLine($"Hola, {nombre} {apellido}!");

                Console.WriteLine(" Desea ingresar otro nombre y apellido? (s/n)");
                respuesta = Console.ReadLine().ToLower();

            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine(" Respuesta no válida. Por Favor, ingrese 's' para continuar o 'n' para salir: ");
                respuesta = Console.ReadLine().ToLower();

            }
                //continuar = (respuesta == "s");


            }
        Console.WriteLine("Gracias por utilizar este programa. Presione cualquier tecla para salir");
        Console.ReadKey();


    }// while (continuar);







}