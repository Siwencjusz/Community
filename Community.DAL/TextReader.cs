using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.Enums;

namespace Community.DAL
{
    public class SqlReader
    {

        public string Read(ESqlFileNames fileNames)
        {
                var fileName = fileNames.ToString();
                string path = AppDomain.CurrentDomain.BaseDirectory + "Scripts/" + fileName + ".sql";
                if (File.Exists(path))
                {
                string command = File.ReadAllText(path);
                return command;
                }
            throw new ApplicationException();


        }
    }
}
