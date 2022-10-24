using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace procedimientos_interconexion
{
    public class Log
    {
        private string Path = "";
        private string Brinco = "/n";


        public Log(string Path)
        {
            this.Path = Path;
        }

        public void Add(string sLog)
        {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";

            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();
        }

        #region HELPER
        private string GetNameFile()
        {
            string nombre = "";

           
            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

            return nombre;

        }
            
            
        
        private bool CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
                return true;
            }
            catch(DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
           
        }

        #endregion
    }
}
