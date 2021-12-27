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
            wklejonen.Source = new BitmapImage(new Uri(theDialog.FileName));
        }
        /// uczen
        string plecuu;
        string etyka;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((bool)Etykau.IsChecked) {
                etyka = "Tak";
            }
            else
            {
                etyka = "Nie";
            }
            
            if (plecu.SelectedItem == Ku){
                plecuu = "Kobieta";
            }
            else
            {
                plecuu = "Mężczyzna";
            }
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // zapisywanie do pliku
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "uczen.txt")))
            {
                outputFile.WriteLine($"{Imieu.Text}\n{xImieu.Text}\n{Nazwiskou.Text}\n{ImieMu.Text}\n{ImieTu.Text}\n{urodzeniau.Text}\n{Peselu.Text}\n{plecuu}\n{Klasau.Text}\n{Grupau.Text}\n{etyka}");                                 
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.InitialDirectory = @"C:\";
            theDialog.ShowDialog();
            wklejonep.Source = new BitmapImage(new Uri(theDialog.FileName));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.InitialDirectory = @"C:\";
            theDialog.ShowDialog();
            wklejoneu.Source = new BitmapImage(new Uri(theDialog.FileName));
        }


        /// pracownik
        string plecpp;
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (plecp.SelectedItem == Ku)
            {
                plecpp = "Kobieta";
            }
            else
            {
                plecpp = "Mężczyzna";
            }
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // zapisywanie do pliku
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "pracownik.txt")))
            {
                outputFile.WriteLine($"{Imiep.Text}\n{xImiep.Text}\n{Nazwiskop.Text}\n{ImieMp.Text}\n{ImieTp.Text}\n{urodzeniap.Text}\n{Peselp.Text}\n{plecpp}\n{Etatp.Text}\n{Stanowiskop.Text}\n{Zatrudnieniap.Text}");
            }
        }
        /// nauczyciel
        string wycho;
        string plecnn;
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            wypiszn.Content += ($"{Imien.Text} {Imiexn.Text} {Nazwiskon.Text} {ImieMn.Text} {ImieTn.Text} {urodzenian.Text} {Peseln.Text} {plecnn} {wycho} {Stanowiskop.Text} {Przedmiotyn.Text} {Klasyn.Text} {Ilosc_godzinn.Text} {Zatrudnienian.Text}\n");
            if ((bool)Wychon.IsChecked)
            {
                wycho = "Tak";
            }
            else
            {
                wycho = "Nie";
            }
            if (plecn.SelectedItem == Ku)
            {
                plecnn = "Kobieta";
            }
            else
            {
                plecnn = "Mężczyzna";
            }
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // zapisywanie do pliku
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "nauczyciel.txt")))
            {
                outputFile.WriteLine($"{Imien.Text}\n{Imiexn.Text}\n{Nazwiskon.Text}\n{ImieMn.Text}\n{ImieTn.Text}\n{urodzenian.Text}\n{Peseln.Text}\n{plecnn}\n{wycho}\n{Stanowiskop.Text}\n{Przedmiotyn.Text}\n{Klasyn.Text}\n{Ilosc_godzinn.Text}\n{Zatrudnienian.Text}");
            }

        }
    }
}
