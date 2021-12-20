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
using System.IO;
using Microsoft.Win32;

namespace Sarkofag
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.InitialDirectory = @"C:\";
            theDialog.ShowDialog();
            wklejone.Source = new BitmapImage(new Uri(theDialog.FileName));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // zapisywanie do pliku
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "uczen.txt")))
            {
                    outputFile.WriteLine($"{Imieu.Text}\n{xImieu.Text}\n{Nazwiskou.Text}\n{ImieMu.Text}\n{ImieTu.Text}\n{urodzeniau.Text}\n{Peselu.Text}\n{plecu.SelectedValue.ToString()}");                                   
            }
        }
    }
}
