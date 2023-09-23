// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace esctruturaswith

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor entre 1 y 4");
            int esctrutura = int.Parse(Console.ReadLine());

                  switch (esctrutura)

            {

                case 1:
                    Console.WriteLine("Hola mundo");

                    break;
                case 2:
                    Console.WriteLine("Bienvenido al sistema");

                    break;
                case 3:
                    Console.WriteLine("Somos libres");

                    break;
                case 4:
                    Console.WriteLine("Logramos arreglarlo");

                    break;

                default:
                    Console.WriteLine("esta opcion no exixte");

                    break;
            }
        }
    }
}
          
            
        

    


