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
    /// Lógica interna para ListCurso.xaml
    /// </summary>
    public partial class ListCurso : Window
    {
        public ListCurso()
        {
            InitializeComponent();
            ListDepartamentos.ItemsSource = NDepartamento.Listar();
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {

            if (ListDepartamentos.SelectedItem != null)
            {
                MDepartamento d = (MDepartamento)ListDepartamentos.SelectedItem;
                ListCursos.ItemsSource = null;
                ListCursos.ItemsSource = NCurso.Listar(d);
            }
            else
                MessageBox.Show("É preciso selecionar um Departamento");
        }
    }
}
