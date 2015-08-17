using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // SERIALIZACION

            FileStream fs = new FileStream("SerializatedString.Data", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, DateTime.Now);

            fs.Close();

            Console.WriteLine("Se realizo la serializacion de la fecha.");
            Console.ReadKey();

            // DESEREALIZACION

            FileStream fsOpen = new FileStream("SerializatedDate.Data", FileMode.Open);

            DateTime Hora = new DateTime();

            Hora = (DateTime)bf.Deserialize(fsOpen);

            fsOpen.Close();

            Console.WriteLine(Hora.ToString());
            Console.ReadKey();           


        }
    }
}
