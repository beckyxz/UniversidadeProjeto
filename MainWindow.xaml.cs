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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UniversidadeProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void UniversidadeWindow_Click(object sender, RoutedEventArgs e)
        {
            UniversidadeWindow w = new UniversidadeWindow();
            w.ShowDialog();
        }
        private void DepartamentoWindow_Click(object sender, RoutedEventArgs e)
        {
            DepartamentoWindow w = new DepartamentoWindow();
            w.ShowDialog();
        }
        private void CursoWindow_Click(object sender, RoutedEventArgs e)
        {
            CursoWindow w = new CursoWindow();
            w.ShowDialog();
        }
  
        private void CadDepWindow_Click(object sender, RoutedEventArgs e)
        {
            CadDepartamento w = new CadDepartamento();
            w.ShowDialog();
        }

        private void CadCursoWindow_Click(object sender, RoutedEventArgs e)
        {

            CadCurso w = new CadCurso();
            w.ShowDialog();
        }

        private void ListDepWindow_Click(object sender, RoutedEventArgs e)
        {
            ListDep w = new ListDep();
            w.ShowDialog();

        }

        private void ListCursoWindow_Click(object sender, RoutedEventArgs e)
        {
            ListCurso w = new ListCurso();
            w.ShowDialog();

        }

        
    }
}
   