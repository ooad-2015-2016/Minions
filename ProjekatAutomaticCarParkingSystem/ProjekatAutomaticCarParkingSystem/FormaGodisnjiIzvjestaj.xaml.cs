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
    public sealed partial class FormaGodisnjiIzvjestaj : Page
    {
        public FormaGodisnjiIzvjestaj()
        {
            this.InitializeComponent();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<KLASE.Isplata> isplatezadnjaGodina = new List<KLASE.Isplata>();
            decimal ukupnom = 0m;
            foreach (KLASE.Isplata item in KontejnerskaKlasa.isplate)
            {
                //ako je proslo 0 godina izmedju danasnjeg dana i dana isplate i 0 mjeseci znaci
                //da je bila u zadnjem mjesecu isplata
                if (item.DatumIsplate.Year - DateTime.Now.Year == 0 )
                    isplatezadnjaGodina.Add(item);
            }
            foreach (KLASE.Isplata isplata in isplatezadnjaGodina)
            {
                //za svaku isplatu koja se nalazi u zadnjem mjesecu saberi cijene i dodaj na ukupno;
                ukupnom += isplata.Cijena;
            }
            List<string> listaisplataitotal = new List<string>();
            foreach (KLASE.Isplata isplata in isplatezadnjaGodina)
            {
                listaisplataitotal.Add(isplata.ToString());
            }
            listaisplataitotal.Add(string.Format("Ukupno isplaceno ovog mjeseca: {0}", ukupnom));
            listView.ItemsSource = listaisplataitotal;

            //Uplate:
            List<KLASE.Uplata> uplatezadnjaGodina = new List<KLASE.Uplata>();
            decimal ukupnom_uplate = 0m;
            foreach (KLASE.Uplata item in KontejnerskaKlasa.uplate)
            {
                //ako je proslo 0 godina izmedju danasnjeg dana i dana uplate i 0 mjeseci znaci
                //da je bila u zadnjem mjesecu uplata
                if (item.DatumUplate.Year - DateTime.Now.Year == 0)
                    uplatezadnjaGodina.Add(item);
            }
            foreach (KLASE.Uplata uplata in uplatezadnjaGodina)
            {
                //za svaku uplatu koja se nalazi u zadnjem mjesecu saberi cijene i dodaj na ukupno;
                ukupnom_uplate += uplata.Vrijednost;
            }
            List<string> listauplataitotal = new List<string>();
            foreach (KLASE.Uplata uplata in uplatezadnjaGodina)
            {
                listauplataitotal.Add(uplata.ToString());
            }
            listauplataitotal.Add(string.Format("Ukupno uplaceno ovog mjeseca: {0}", ukupnom_uplate));
            listView1.ItemsSource = listauplataitotal;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
