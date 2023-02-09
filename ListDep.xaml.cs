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
    /// Lógica interna para ListDep.xaml
    /// </summary>
    public partial class ListDep : Window
    {
        public ListDep()
        {
            InitializeComponent();
            ListUniversidades.ItemsSource = NUniversidade.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (ListUniversidades.SelectedItem != null)
            {
                MUniversidade u = (MUniversidade)ListUniversidades.SelectedItem;
                ListDepartamentos.ItemsSource = null;
                ListDepartamentos.ItemsSource = NDepartamento.Listar(u);
            }
            else
                MessageBox.Show("É preciso selecionar uma Universidade");
        }

    }
}

      
 
