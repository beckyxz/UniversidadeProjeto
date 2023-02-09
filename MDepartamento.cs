using System;
using System.Collections.Generic;
using System.Text;

namespace UniversidadeProj
{
   public class MDepartamento
    {
        public int Id { get; set; }
        public string Departamento { get; set; }
        public int Setor { get; set; }
        public int IdUniversidade { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Departamento} - {Setor} - Universidade: {IdUniversidade}";
        }
    }
}
