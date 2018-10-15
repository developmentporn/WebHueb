using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using BoldyBuildhui.Models;
using Newtonsoft;
using Newtonsoft.Json;

namespace BoldyBuildhui
{
    public class Serializer
    {
        static public T deserialize<T>(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string data = reader.ReadToEnd();
            T rootObject = JsonConvert.DeserializeObject<T>(data);
            reader.Close();
            return rootObject;
        }
    }
}