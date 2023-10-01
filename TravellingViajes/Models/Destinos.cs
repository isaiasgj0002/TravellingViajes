using System;
using System.Collections.Generic;
using System.Text;

namespace TravellingViajes.Models
{
    public  class Destino
    {
        public string Name { get;set;}
        public string Description { get;set;}
        public string Url { get;set;}
        public override string ToString()
        {
            return Name;
        }
    }
}
