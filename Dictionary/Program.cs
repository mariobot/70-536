using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Album de carlos santana            
            Album Album_Carlos = new Album();

            Album_Carlos.id_Album = "1";
            Album_Carlos.nombre = "Europa";
            Album_Carlos.artista = "Carlos Santana";
            Album_Carlos.canciones = 13;
            Album_Carlos.valor = 25000;

            // Album de Robben Ford            
            Album Album_Robben = new Album();

            Album_Robben.id_Album = "2";
            Album_Robben.nombre = "Wath do you think";
            Album_Robben.artista = "Robben Ford";
            Album_Robben.canciones = 15;
            Album_Robben.valor = 35000;


            Dictionary<int, Album> Albumes = new Dictionary<int, Album>();

            Albumes.Add(1,Album_Carlos);
            Albumes.Add(2, Album_Robben);

            foreach (KeyValuePair<int,Album> item_Albumes in Albumes)
            {
                Console.WriteLine("Key: {0} ---- Album: {1} * Artista: {2} * Valor: {3}", item_Albumes.Key, item_Albumes.Value.nombre, item_Albumes.Value.artista, item_Albumes.Value.valor);
            }

            Console.ReadKey();
        }
    }
}
