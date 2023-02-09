using System;
using System.Collections.Generic;
using System.Text;
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
    /// Lógica interna para CadDepartamento.xaml
    /// </summary>
    public partial class CadDepartamento : Window
    {
        public CadDepartamento()
        {
            InitializeComponent();

        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listUniversidades.ItemsSource = null;
            listUniversidades.ItemsSource = NUniversidade.Listar();
            listDepartamentos.ItemsSource = null;
            listDepartamentos.ItemsSource = NDepartamento.Listar();
        }
        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listUniversidades.SelectedItem != null && listDepartamentos.SelectedItem != null)
            {
                MDepartamento d = (MDepartamento)listDepartamentos.SelectedItem;
                MUniversidade u = (MUniversidade)listUniversidades.SelectedItem;
                NDepartamento.Cadastrar(d, u);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um Departamento e uma Universidade");
            }
        }

       
    }
}

