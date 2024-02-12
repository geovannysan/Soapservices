using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soapnet.Models
{
    public class Root
    {
        public int id { get; set; }
        public string? name { get; set; }
        public List<Name>? names { get; set; }
        public List<Value>? values { get; set; }
    }
    public class Language
    {
        public string? name { get; set; }
        public string? url { get; set; }
    }

    public class Name
    {
        public Language? language { get; set; }
        public string? name { get; set; }
    }

    public class Value
    {
        public string? name { get; set; }
        public string? url { get; set; }
    }

}