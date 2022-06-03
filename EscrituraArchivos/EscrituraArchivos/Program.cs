using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Persona
    {
        public string nombre, genero, cancion;
        public Persona(string nombre, string cancion, string genero)
        {
            this.nombre = nombre;
            this.cancion = cancion;
            this.genero = genero;
        }
        
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            
            string nombre, cancion, genero;
            Console.WriteLine("Ingrese sus datos");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Nombre de una cancion: ");
            cancion = Console.ReadLine();
            Console.Write("Genero: ");
            genero = Console.ReadLine();

            Persona nueva = new Persona(nombre, cancion, genero);

           
            sw.WriteLine("Nombre: " + nueva.nombre + ", Cancion: " + nueva.cancion + ", Genero: " + nueva.genero);
            
             sw.Close();
       
             Console.WriteLine("Escribiendo...");
             Console.ReadLine();
        }
    }
}
