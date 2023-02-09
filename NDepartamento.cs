using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace UniversidadeProj
{
    class NDepartamento
    {
        private static List<MDepartamento> departamentos = new List<MDepartamento>();
        public static void Inserir(MDepartamento d)
        {

            Abrir();
            int id = 0;
            foreach (MDepartamento obj in departamentos)
                if (obj.Id > id) id = obj.Id;
            d.Id = id + 1;
            departamentos.Add(d);
            Salvar();
        }
        public static List<MDepartamento> Listar()
        {
            Abrir();
            return departamentos;
        }
        public static void Atualizar(MDepartamento d)
        {
            Abrir();
            foreach (MDepartamento obj in departamentos)
                if (obj.Id == d.Id)
                {
                    obj.Departamento = d.Departamento;
                    obj.Setor = d.Setor;
                    obj.IdUniversidade = d.IdUniversidade;
                }
            Salvar();
        }
        public static void Excluir(MDepartamento d)
        {
            Abrir();
            MDepartamento x = null;
            foreach (MDepartamento obj in departamentos)
                if (obj.Id == d.Id) x = obj;
            if (x != null) departamentos.Remove(x);
            Salvar();
        }

        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<MDepartamento>));
                f = new StreamReader("./departamentos.xml");
                departamentos = (List<MDepartamento>)xml.Deserialize(f);
            }
            catch
            {
                departamentos = new List<MDepartamento>();
            }
            if (f != null) f.Close();
        }
        
        
        
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<MDepartamento>));
            StreamWriter f = new StreamWriter("./departamentos.xml", false);
            xml.Serialize(f, departamentos);
            f.Close();
        }
        public static void Cadastrar(MDepartamento d, MUniversidade u)
        {
            d.IdUniversidade = u.Id;
            Atualizar(d);
        }
        public static List<MDepartamento> Listar(MUniversidade u)
        {
            Abrir();
            List<MDepartamento> listdepartamentos = new List<MDepartamento>();
            foreach (MDepartamento obj in departamentos)
                if (obj.IdUniversidade == u.Id) listdepartamentos.Add(obj);
            return listdepartamentos;
        }
    }
}

