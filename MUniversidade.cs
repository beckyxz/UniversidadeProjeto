using System;
using System.Collections.Generic;
using System.Text;

namespace UniversidadeProj
{
     public class MUniversidade
    {
        public int Id { get; set; }
        public string Universidade { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Universidade}";
        }
    }
}
