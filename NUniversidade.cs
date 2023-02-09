using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace UniversidadeProj
{
    class NUniversidade
        {
            private static List<MUniversidade> universidades = new List<MUniversidade>();
            public static void Inserir(MUniversidade u)
            {
                Abrir();
                int id = 0;
                foreach (MUniversidade obj in universidades)
                    if (obj.Id > id) id = obj.Id;
                u.Id = id + 1;
                universidades.Add(u);
                Salvar();
            }
            public static List<MUniversidade> Listar()
            {
                Abrir();
                return universidades;
            }
            public static void Atualizar(MUniversidade u)
            {
                Abrir();
                foreach (MUniversidade obj in universidades)
                    if (obj.Id == u.Id)
                    {
                        obj.Universidade = u.Universidade;
                    }
                Salvar();
            }

            public static void Excluir(MUniversidade u)
            {
                Abrir();
                MUniversidade x = null;
                foreach (MUniversidade obj in universidades)
                    if (obj.Id == u.Id) x = obj;
                if (x != null) universidades.Remove(x);
                Salvar();
            }
            public static void Abrir()
            {
                StreamReader f = null;
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<MUniversidade>));
                    f = new StreamReader("./universidade.xml");
                    universidades = (List<MUniversidade>)xml.Deserialize(f);
                }
                catch
                {
                    universidades = new List<MUniversidade>();
                }
                if (f != null) f.Close();
            }
            public static void Salvar()
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<MUniversidade>));
                StreamWriter f = new StreamWriter("./universidade.xml", false);
                xml.Serialize(f, universidades);
                f.Close();
            }
        }
    }

