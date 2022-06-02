using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class persona
    {
        string nombre, genero, cancion;
        public persona(string nombre, string cancion, string genero)
        {
            this.nombre = nombre;
            this.cancion = cancion;
            this.genero = genero;
        }
        public string no()
        {
            return nombre;
        }
        public string ca()
        {
            return cancion;
        }
        public string ge()
        {
            return genero;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //Si el archivo no extiste lo creara
            //Si el archivo exoste escribira en el 
            string nombre, cancion, genero;
            Console.WriteLine("Ingrese sus datos");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Nombre de una cancion: ");
            cancion = Console.ReadLine();
            Console.Write("Genero: ");
            genero = Console.ReadLine();

            persona nueva = new persona(nombre, cancion, genero);

           
            sw.WriteLine("Nombre: " + nueva.no() + ", Cancion: " + nueva.ca() + ", Genero: " + nueva.ge());
            
             sw.Close();
       
             Console.WriteLine("Escribiendo...");
             Console.ReadLine();
        }
    }
}
