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
    public sealed partial class FormaUnosKorisnikavol2 : Page
    {
        public FormaUnosKorisnikavol2()
        {
            this.InitializeComponent();
        }
//event za klik na dugme dodaj
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //validacija
            foreach (char slovo in textBox.Text)
            {
                if (!Char.IsLetter(slovo))
                {
                    textBlock10.Visibility = Visibility.Visible;
                    textBlock10.Text = "Ime nije validno, unesite opet";
                    return;

                }
            }
            foreach (char slovo in textBox1.Text)
            {
                if (!Char.IsLetter(slovo))
                {
                    textBlock10.Visibility = Visibility.Visible;
                    textBlock10.Text = "Prezime nije validno, unesite opet";
                    return;

                }
            }
            foreach (char broj in textBox2.Text)
            {
                if (!Char.IsDigit(broj))
                {
                    textBlock10.Visibility = Visibility.Visible;
                    textBlock10.Text = "Broj telefona nije validan, unesite broj u formatu 0038xxxxxxxxx";
                    return;
                }
            }
            if (datumrodj.Date.Year < 1920 || datumrodj.Date.Year > 1997)
            { textBlock10.Text = "Niste unijeli dobro datum rođenja."; return; }
            if (textBox4.Text.Length != 14) { textBlock10.Text = "Pogresan format broja licne karte"; return; }
            foreach (Korisnik item in KontejnerskaKlasa.korisnici)
            {
                if (item.Username == textBox5.Text) { textBlock10.Text = "Username vec zauzet."; return; }
            }
            if (textBox5.Text.Length > 10) { textBlock10.Text = "Username ne moze biti duzi od 10 znakova"; return; }
            if (passwordBox.Password.Length > 16) { textBlock10.Text = "Password ne moze btii duzi od 16 znakoma"; return; }
            
            foreach (char slovo in textBox3.Text)
            {
                if (!Char.IsLetter(slovo))
                {
                    textBlock10.Visibility = Visibility.Visible;
                    textBlock10.Text = "Adresa nije validna";
                    return;
                }
            }
            //ako prodju sve validacije
            //dodajemo korisnika u kontejnersku klasu
            KontejnerskaKlasa.korisnici.Add(new Korisnik(textBox.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, datumrodj.Date.DateTime, textBox8.Text, textBox7.Text, textBox5.Text, passwordBox.Password));
            Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
            if (window != null)
            {
                Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                if (frame != null)
                {
                    frame.Navigate((typeof(FormaDezurniRadnik)));
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
            if (window != null)
            {
                Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                if (frame != null)
                {
                    frame.Navigate((typeof(FormaDezurniRadnik)));
                }
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBlock10_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
