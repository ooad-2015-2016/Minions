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
    public sealed partial class FormaRadnikDosao : Page
    {
        public FormaRadnikDosao()
        {
            this.InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textBlock.Text = string.Format("Trenutno je {0}", DateTime.Now);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(textBox.Text.Length ==10)
            {
                bool nasao = false;
                foreach (DezurniRadnik item in KontejnerskaKlasa.dezurniRadnici)
                {
                    if (item.RFID == textBox.Text)
                    {
                        nasao = true;
                        KontejnerskaKlasa.dolasci.Add(new DolazakNaPosao(DateTime.Now, textBox.Text));
                        
                        double ukupnoSati = 0;
                        List<DateTime> listavremena = new List<DateTime>();
                        foreach (DolazakNaPosao dolazak in KontejnerskaKlasa.dolasci)
                        {
                            if (dolazak.RFID_==textBox.Text)
                            {
                                listavremena.Add(dolazak.Vrijeme);
                            }
                            
                        }
                        for (int i = 0; i < listavremena.Count; i++)
                        {
                            for (int j = i+1; j < listavremena.Count; j++)
                            {
                                if (listavremena[i].Date.Day==listavremena[j].Date.Day)
                                {
                                    TimeSpan razlika = listavremena[j] - listavremena[i];
                                    if (listavremena[j].Year==DateTime.Now.Year && listavremena[i].Month == DateTime.Now.Month)
                                    {
                                        ukupnoSati += razlika.TotalHours;
                                    }
                                    
                                }
                            }
                        }

                        textBlock2.Text = string.Format("Vi ste {0} {1} i zadnji mjesec ste radili {2} sati.", item.Ime, item.Prezime, Convert.ToInt32(ukupnoSati));


                        return;
                        
                    }
                }
                if (!nasao)
                {
                    textBlock2.Text = "Niste u bazi dezurnih radnika, javite se supervizoru da vas registruje.";
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
            if (window != null)
            {
                Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                if (frame != null)
                {
                    frame.Navigate((typeof(MainPage)));
                }
            }
        }
    }
}
