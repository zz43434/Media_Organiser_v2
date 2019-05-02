using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Organiser.Logic
{
    public class Json
    {
        public static void saveToJson<T>(string filePath, T objectToSave, bool append = false) where T : new()
        {
            TextWriter file = null;
            try
            {
                var saveFile = JsonConvert.SerializeObject(objectToSave);
                file = new StreamWriter(filePath, append);
                file.Write(saveFile);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

        public static T ReadSavedObject<T>(string filePath) where T : new()
        {
            TextReader readFile = null;
            try
            {
                readFile = new StreamReader(filePath);
                var file = readFile.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(file);
            }
            finally
            {
                if (readFile != null)
                    readFile.Close();
            }
        }
    }
}
