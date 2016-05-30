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
    public sealed partial class FormaIzvjestajMajstora : Page
    {
        public FormaIzvjestajMajstora()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
            if (window != null)
            {
                Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                if (frame != null)
                {
                    frame.Navigate((typeof(FormaLogin)));
                }
            }
        }

        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBlock6_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            decimal broj;
            bool jelDecimalni = decimal.TryParse(textBox5.Text, out broj);
            if (!jelDecimalni)
            {

                textBlock6.Text = "Neispravna cijena!";
                return;
            }


            KontejnerskaKlasa.isplate.Add(new KLASE.Isplata(broj, datum.Date.DateTime, textBox1.Text));
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
