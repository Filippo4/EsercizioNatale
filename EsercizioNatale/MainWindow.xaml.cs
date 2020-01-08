using System;
using System.Collections.Generic;
using System.IO;
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

namespace EsercizioNatale
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_importa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("FileValido.txt");
                string line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    
                    lsv_lista.Items.Add(line);
                }
            }
            catch
            {

            }
        }
    }
}
