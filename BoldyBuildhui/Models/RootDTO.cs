using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoldyBuildhui.Models
{
    public class RootDTO<T>
    {
        public string Type { get; set; }
        public string Version { get; set; }
        public Dictionary<string, T> Data { get; set; }
    }
}