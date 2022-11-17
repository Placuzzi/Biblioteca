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

namespace Biblioteca_VerificaGit
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

        private void Agg_Libro_Click(object sender, RoutedEventArgs e)
        {
            Libro libro = new Libro();
            Biblioteca Libri = new Biblioteca();
            libro.Autore = Autore.Text;
            libro.Titolo = Titolo.Text;
            libro.Anno = Anno.Text;
            libro.Editor = Editor.Text;
            libro.NumPagine = Num_Pagine.Text;
            Libri.Libri.Add(libro);

            
            ElencoLibri.Items.Add(Libri.Libri);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Biblioteca biblioteca = new Biblioteca ()
        }
    }
}
