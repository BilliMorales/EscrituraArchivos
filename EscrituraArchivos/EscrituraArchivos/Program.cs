using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //Si el archivo no extiste lo creara
            //Si el archivo exoste escribira en el 
            String[] lines =
            {
                "Esto es la nueva perimera linea",
                "Esta es la segunda linea",
                "Esto es la tercer linea",
            };
            //Recorre el arreglo para escribir las lineas
            foreach(string line in lines)
            {
                //escribe en el archivo
                sw.WriteLine(line);
            }
            sw.Close();

            Console.WriteLine("Escribiendo...");
            Console.ReadLine();
        }
    }
}
