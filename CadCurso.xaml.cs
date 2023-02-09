using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UniversidadeProj
{
    /// <summary>
    /// Lógica interna para CadCurso.xaml
    /// </summary>
    public partial class CadCurso : Window
    {
        public CadCurso()
        {
            InitializeComponent();
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listDepartamentos.ItemsSource = null;
            listDepartamentos.ItemsSource = NDepartamento.Listar();
            listCursos.ItemsSource = null;
            listCursos.ItemsSource = NCurso.Listar();
        }
        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listDepartamentos.SelectedItem != null && listCursos.SelectedItem != null)
            {
                MCurso c = (MCurso)listCursos.SelectedItem;
                MDepartamento d = (MDepartamento)listDepartamentos.SelectedItem;
                NCurso.Cadastrar(c, d);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um Curso e um Departamento");
            }
        }
    }
}
    