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
    /// Lógica interna para DepartamentoWindow.xaml
    /// </summary>
    public partial class DepartamentoWindow : Window
    {
        public DepartamentoWindow()
        {
            InitializeComponent();
        }
        private void InserirClick(object sender, RoutedEventArgs e)
        {
            MDepartamento d = new MDepartamento();
            d.Id = int.Parse(txtId.Text);
            d.Departamento = txtDepartamento.Text;
            d.Setor = int.Parse(txtSetor.Text);
            NDepartamento.Inserir(d);
            ListarClick(sender, e);
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listDepartamentos.ItemsSource = null;
            listDepartamentos.ItemsSource = NDepartamento.Listar();
        }
        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            MDepartamento d = new MDepartamento();
            d.Id = int.Parse(txtId.Text);
            d.Departamento = txtDepartamento.Text;
            d.Setor = int.Parse(txtSetor.Text);

            NDepartamento.Atualizar(d);
            ListarClick(sender, e);
        }
        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            MDepartamento d = new MDepartamento();
            d.Id = int.Parse(txtId.Text);
            NDepartamento.Excluir(d);
            ListarClick(sender, e);
        }
        private void ListDepartamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listDepartamentos.SelectedItem != null)
            {
                MDepartamento obj = (MDepartamento)listDepartamentos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtDepartamento.Text = obj.Departamento;
                txtSetor.Text = obj.Setor.ToString();
            }

        }
    }
}

