using System;
using System.Collections.Generic;
using System.Text;

namespace UniversidadeProj
{
    public class MCurso
    {
        public int Id { get; set; }
        public string Curso { get; set; }
        public int Codigo { get; set; }
        public string Turno { get; set; }
        public int IdDepartamento { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Curso} - {Codigo} - {Turno} - Departamento: {IdDepartamento}";
        }
    }
}

