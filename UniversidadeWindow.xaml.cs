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
    /// Lógica interna para UniversidadeWindow.xaml
    /// </summary>
    public partial class UniversidadeWindow : Window
    {
        public UniversidadeWindow()
        {
            InitializeComponent();
        }
       
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (listUniversidades.SelectedItem != null)
            {
                MUniversidade obj = (MUniversidade)listUniversidades.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtUniversidade.Text = obj.Universidade;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MUniversidade u = new MUniversidade();
            u.Id = int.Parse(txtId.Text);
            u.Universidade = txtUniversidade.Text;
            NUniversidade.Inserir(u);
            Listar_Click(sender, e);
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            listUniversidades.ItemsSource = null;
            listUniversidades.ItemsSource = NUniversidade.Listar();

        }

        private void Atualizar_Click(object sender, RoutedEventArgs e)
        {
            MUniversidade u = new MUniversidade();
            u.Id = int.Parse(txtId.Text);
            u.Universidade = txtUniversidade.Text;

            NUniversidade.Atualizar(u);
            Listar_Click(sender, e);

        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            MUniversidade u = new MUniversidade();
            u.Id = int.Parse(txtId.Text);
            NUniversidade.Excluir(u);
            Listar_Click(sender, e);

        }
    }
}
  

