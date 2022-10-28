<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
=======
﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


>>>>>>> main

namespace procedimientos_interconexion
{
    public class Log
    {
        private string Path = "";
<<<<<<< HEAD
        private string Brinco = "/n";

=======

        public object Request { get; private set; }
>>>>>>> main

        public Log(string Path)
        {
            this.Path = Path;
        }

        public void Add(string sLog)
        {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";
<<<<<<< HEAD

            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();
=======
            
            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

           
            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();

>>>>>>> main
        }

        #region HELPER
        private string GetNameFile()
        {
            string nombre = "";

<<<<<<< HEAD
           
            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

            return nombre;

        }
            
            
        
        private bool CreateDirectory()
=======

            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";





            return nombre;
        }


        private void CreateDirectory()
>>>>>>> main
        {
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
<<<<<<< HEAD
                return true;
            }
            catch(DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
           
        }

        #endregion
=======


            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);

            }
        }
        #endregion


>>>>>>> main
    }
}
