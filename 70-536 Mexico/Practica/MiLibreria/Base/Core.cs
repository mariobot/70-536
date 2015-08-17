using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace MiLibreria.Base
{
    
    public class Core
    {

        #region Variables        
        
        string cad = string.Empty;

        #endregion

        #region Metodos Publicos

        public string Serializacion(string otroTexto) 
        {
        
            string respuesta = string.Empty;
            respuesta = CadenaSerializada();

            return respuesta + otroTexto;
        }

        #endregion

        #region Metodos Privados

        private string CadenaSerializada() 
        {
            //cad = "Hola mundo";
            cad = CadenaDes();
            ArchivoTexto(cad);
            cad = CadenaDes();

            return cad;
        }
        
        /// <summary>
        /// Agrega el texto archivo de texto plano
        /// </summary>
        /// <param name="texto">Mensaje</param>
        private void ArchivoTexto(string texto) 
        {
            
            FileStream fs = new FileStream(@"E:\Archivo.dat",FileMode.OpenOrCreate);
            
            BinaryFormatter bf = new BinaryFormatter();
            
            bf.Serialize(fs, texto);            
            
            fs.Close();

        }

        private string CadenaDes()
        {
            string cadenaDos = string.Empty;
            
            FileStream fs = new FileStream(@"E:\Archivo.dat", FileMode.Open);
            
            BinaryFormatter bf = new BinaryFormatter();

            cadenaDos = (string)bf.Deserialize(fs);
            
            fs.Close();
            
            return cadenaDos;
 
        }

        #endregion

    }
}
