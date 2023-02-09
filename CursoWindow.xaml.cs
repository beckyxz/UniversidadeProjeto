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
    /// Lógica interna para CursoWindow.xaml
    /// </summary>
    public partial class CursoWindow : Window
    {
        public CursoWindow()
        {
            InitializeComponent();
        }


        private void InserirClick(object sender, RoutedEventArgs e)
        {

            MCurso c = new MCurso();
            c.Id = int.Parse(txtId.Text);
            c.Codigo = int.Parse(txtCodigo.Text);
            c.Curso = txtCurso.Text;
            c.Turno = txtTurno.Text;
            NCurso.Inserir(c);

            ListarClick(sender, e);
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listCursos.ItemsSource = null;
            listCursos.ItemsSource = NCurso.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {

            MCurso c = new MCurso();
            c.Id = int.Parse(txtId.Text);
            c.Codigo = int.Parse(txtCodigo.Text);
            c.Curso = txtCurso.Text;
            c.Turno = txtTurno.Text;
            NCurso.Atualizar(c);

            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {

            MCurso c = new MCurso();
            c.Id = int.Parse(txtId.Text);
            NCurso.Excluir(c);
            ListarClick(sender, e);
        }

        private void ListCursos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listCursos.SelectedItem != null)
            {
                MCurso obj = (MCurso)listCursos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtCodigo.Text = obj.Codigo.ToString();
                txtCurso.Text = obj.Curso;
                txtTurno.Text = obj.Turno;
            }
        }
    }
}