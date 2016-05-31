using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatAutomaticCarParkingSystem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //za dnevni izvjestaj
            //nova lista u kojoj ce biti sve isplate kojim je datum u zadnjem danu
            List<KLASE.Isplata> isplateZadnjiDan = new List<KLASE.Isplata>();
            foreach (KLASE.Isplata item in KontejnerskaKlasa.isplate)
            {
                //razlika vremena isplate i danasnjeg datuma:
                TimeSpan razlika = item.DatumIsplate - DateTime.Now;
                if (razlika.TotalDays < 0 && razlika.TotalDays>-1)
                    isplateZadnjiDan.Add(item);
            }
            listView.ItemsSource = isplateZadnjiDan;
            decimal ukupno = 0m;
            foreach (KLASE.Isplata isplata in isplateZadnjiDan)
            {
                //za svaku isplatu koja se nalazi u zadnjem danu saberi cijene i dodaj na ukupno;
                ukupno += isplata.Cijena;
            }
            //dodaj kao zadnji element obavijest o ukupnoj isplacenoj vrijednosti
            //napravi listu sttringova sa svim isplatama
            List<string> listaisplataitotal = new List<string>();
            foreach (KLASE.Isplata isplata in isplateZadnjiDan)
            {
                listaisplataitotal.Add(isplata.ToString());
            }
            //dodaj u listu total
            listaisplataitotal.Add(string.Format("Ukupno isplaceno danas: {0}", ukupno));
            //postavi kao izvor podataka listu stringova
            listView.ItemsSource = listaisplataitotal;

            // Uplate

            List<KLASE.Uplata> uplateZadnjiDan = new List<KLASE.Uplata>();
            foreach (KLASE.Uplata item in KontejnerskaKlasa.uplate)
            {
                //razlika vremena isplate i danasnjeg datuma:
                TimeSpan razlika = item.DatumUplate - DateTime.Now;
                if (razlika.TotalDays < 0 && razlika.TotalDays > -1)
                    uplateZadnjiDan.Add(item);
            }
            listView1.ItemsSource = uplateZadnjiDan;
            decimal ukupno_uplate = 0m;
            foreach (KLASE.Uplata Uplata in uplateZadnjiDan)
            {
                //za svaku isplatu koja se nalazi u zadnjem danu saberi cijene i dodaj na ukupno;
                ukupno_uplate += Uplata.Vrijednost;
            }
            //dodaj kao zadnji element obavijest o ukupnoj isplacenoj vrijednosti
            //napravi listu sttringova sa svim Uplatama
            List<string> listauplataitotal = new List<string>();
            foreach (KLASE.Uplata Uplata in uplateZadnjiDan)
            {
                listauplataitotal.Add(Uplata.ToString());
            }
            //dodaj u listu total
            listauplataitotal.Add(string.Format("Ukupno uplaceno danas: {0}", ukupno_uplate));
            //postavi kao izvor podataka listu stringova
            listView1.ItemsSource = listauplataitotal;
        }

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
            if (window != null)
            {
                Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                if (frame != null)
                {
                    frame.Navigate((typeof(FormaVlasnikIzvjestaji)));
                }
            }
        }
    }
}
