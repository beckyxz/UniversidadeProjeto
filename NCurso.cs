using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace UniversidadeProj
{
    class NCurso
    {
        private static List<MCurso> cursos = new List<MCurso>();
        public static void Inserir(MCurso c)
        {
            Abrir();
            int id = 0;
            foreach (MCurso obj in cursos)
                if (obj.Id > id) id = obj.Id;
            c.Id = id + 1;
            cursos.Add(c);
            Salvar();
        }
        public static List<MCurso> Listar()
        {
            Abrir();
            return cursos;
        }
        public static void Atualizar(MCurso c)
        {
            Abrir();
            foreach (MCurso obj in cursos)
                if (obj.Id == c.Id)
                {
                    obj.Curso = c.Curso;
                    obj.Codigo = c.Codigo;
                    obj.Turno = c.Turno;
                    obj.IdDepartamento = c.IdDepartamento;
                }
            Salvar();
        }
        public static void Excluir(MCurso c)
        {
            Abrir();
            MCurso x = null;
            foreach (MCurso obj in cursos)
                if (obj.Id == c.Id) x = obj;
            if (x != null) cursos.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<MCurso>));
                f = new StreamReader("./cursos.xml");
                cursos = (List<MCurso>)xml.Deserialize(f);
            }
            catch
            {
                cursos = new List<MCurso>();
            }

            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<MCurso>));
            StreamWriter f = new StreamWriter("./cursos.xml", false);
            xml.Serialize(f, cursos);
            f.Close();
        }
        public static void Cadastrar(MCurso c, MDepartamento d)
        {
            c.IdDepartamento = d.Id;
            Atualizar(c);
        }
        public static List<MCurso> Listar(MDepartamento d)
        {
            Abrir();
            List<MCurso> listcursos = new List<MCurso>();
            foreach (MCurso obj in cursos)
                if (obj.IdDepartamento == d.Id) listcursos.Add(obj);
            return listcursos;
        }
    }
}


