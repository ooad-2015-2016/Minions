﻿using System;
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

namespace ProjekatAutomaticCarParkingSystem.FORME
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FormaDodajRadnika : Page
    {
        public FormaDodajRadnika()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
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
            if (datumrodj.Date.Year < 1920 ||datumrodj.Date.Year >1997)
            { textBlock10.Text = "Niste unijeli dobro datum rođenja."; }
            if (textBox4.Text.Length != 14) textBlock10.Text = "Pogresan format broja licne karte";
            if (textBlock5.Text.Length > 10) textBlock10.Text = "Username ne moze biti duzi od 10 znakova";
            if (passwordBox.Password.Length > 16) textBlock10.Text = "Password ne moze btii duzi od 16 znakoma";
            foreach (char slovo in textBox7.Text)
            {
                if (!Char.IsLetter(slovo))
                {
                    textBlock10.Visibility = Visibility.Visible;
                    textBlock10.Text = "Adresa nije validna ukucajte adresu bez broja";
                    return;
                }
            }
            //ako prodju sve validacije
            //dodajemo dez radnika u kontejnersku klasu
            DezurniRadnik radnik = new DezurniRadnik(textBox.Text, textBox1.Text, textBox2.Text,
                textBox3.Text, textBox4.Text, datumrodj.Date.DateTime, textBox5.Text, passwordBox.Password);
            radnik.RFID = textBox7.Text;
            KontejnerskaKlasa.dezurniRadnici.Add(radnik);
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
            if (window != null)
            {
                Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                if (frame != null)
                {
                    frame.Navigate((typeof(FormaSupervizor)));
                }
            }
        }
    }
}
