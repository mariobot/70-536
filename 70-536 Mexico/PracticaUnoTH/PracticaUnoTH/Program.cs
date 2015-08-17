using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
namespace PracticaUnoTH
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero = 1;
            string Cadena = "Hola mundo";
            Point punto = new Point(2, 2);

            try
            {
                Console.WriteLine("Dame un numero");
                string numero = Console.ReadLine();
                int numero2 = Int16.Parse(numero);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Termina la ejecucion");
            }

            for (int i = 0; i > 2; ++i)
            {
                Console.WriteLine("El valor del punto es X: {0} Y:{1}",
                    punto.X, punto.Y);
            }


            List<string> lsstring = new List<string>();
            lsstring.Add("Hola");
            lsstring.Add("TelmexHub");
            foreach (string item in lsstring)
            {
                Console.WriteLine(item);
            }

            List<Persona> lsPersona = new List<Persona>();
            lsPersona.Add(new Persona {
                Edad = 31,
                Nombre = "Jonatahan",
                Peso = 110,
                Talla = 183
            });

            foreach (var itemPersona in lsPersona)
            {
                Console.WriteLine("Nombre: {0}",itemPersona.Nombre);
                Console.WriteLine("Edada: {0}", itemPersona.Edad);
            }
            Dictionary<int, string> dicNumLista = new Dictionary<int, string>();
            dicNumLista.Add(1, "Juan");

        }
    }
}

