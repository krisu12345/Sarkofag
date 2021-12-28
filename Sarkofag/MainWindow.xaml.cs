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
            odswiez();
        }
        private void odswiez()
        {
            string wczytanien = System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\nauczyciel.txt");
            string wczytaniep = System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\uczen.txt");
            string wczytanieu = System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\pracownik.txt");
            wypiszn.Content = wczytanien;
            wypiszp.Content = wczytaniep;
            wypiszu.Content = wczytanieu;
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
            wypiszu.Content = ($"{Imieu.Text} {xImieu.Text} {Nazwiskou.Text} {ImieMu.Text} {ImieTu.Text} {urodzeniau.Text} {Peselu.Text} {plecuu} {Klasau.Text} {Grupau.Text} {etyka}\n");
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
                outputFile.WriteLine($"{Imieu.Text} {xImieu.Text} {Nazwiskou.Text} {ImieMu.Text} {ImieTu.Text} {urodzeniau.Text} {Peselu.Text} {plecuu} {Klasau.Text} {Grupau.Text} {etyka}\n");                                 
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
            wypiszp.Content = ($"{Imiep.Text} {xImiep.Text} {Nazwiskop.Text} {ImieMp.Text} {ImieTp.Text} {urodzeniap.Text} {Peselp.Text} {plecpp} {Etatp.Text} {Stanowiskop.Text} {Zatrudnieniap.Text}\n");
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
                outputFile.WriteLine($"{Imiep.Text} {xImiep.Text} {Nazwiskop.Text} {ImieMp.Text} {ImieTp.Text} {urodzeniap.Text} {Peselp.Text} {plecpp} {Etatp.Text} {Stanowiskop.Text} {Zatrudnieniap.Text}\n");
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
                outputFile.WriteLine($"{Imien.Text} {Imiexn.Text} {Nazwiskon.Text} {ImieMn.Text} {ImieTn.Text} {urodzenian.Text} {Peseln.Text} {plecnn} {wycho} {Stanowiskop.Text} {Przedmiotyn.Text} {Klasyn.Text} {Ilosc_godzinn.Text} {Zatrudnienian.Text}\n");
            }

        }
    }
}
