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
    public sealed partial class FormaLogin : Page
    {
        public FormaLogin()
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
                    frame.Navigate((typeof(MainPage)));
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //provjerava validnost podataka ako vlasnik nije zaboravio pasword
            if (checkBox.IsChecked != true && radioButton.IsChecked == true)
            {
                if (textBox.Text != "jasamglavni")
                {
                    textBlock2.Text = "Pogresno korisnicko ime!!!";

                }
                else if (passwordBox.Password != "1234")
                { textBlock2.Text = "Pogresan password!!!"; }
                else
                {
                    //ako sve okej prodje, otvara se forma za vlasnika
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
            //provjerava validnost podataka ako se loguje korisnik i nije zaboravio pass
            //treba napraviti formu koja ce se prikazati korisniku
            if (checkBox.IsChecked != true && radioButton1.IsChecked == true)
            {
                foreach (Korisnik korisnik in KontejnerskaKlasa.korisnici)
                {
                    if (korisnik.Username == textBox.Text && korisnik.Password == passwordBox.Password)
                    {
                        //ovdje treba napraviti da se otvara forma za korisnika 
                    }

                }
                //ako se ne nadje ni jedan korisnik sa usernameom i pw znaci da je pogrijesio
                textBlock2.Text = "Pogresan username ili password!!!";
            }
            if (checkBox.IsChecked != true && radioButton4.IsChecked == true)
            {
                foreach (Majstor majstor in KontejnerskaKlasa.majstori)
                {
                    if (majstor.Username == textBox.Text && majstor.Password == passwordBox.Password)
                    {
                        Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
                        if (window != null)
                        {
                            Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                            if (frame != null)
                            {
                                frame.Navigate((typeof(FormaIzvjestajMajstora)));
                            }
                        }
                    }

                }
                //ako se ne nadje ni jedan majstor sa usernameom i pw znaci da je pogrijesio
                textBlock2.Text = "Pogresan username ili password!!!";
            }
            //treba dodati za dezurnog radnika i supervizora
            if (checkBox.IsChecked != true && radioButton2.IsChecked == true)
            {
                if (textBox.Text != "mirza95")
                {
                    textBlock2.Text = "Pogresno korisnicko ime!!!";

                }
                else if (passwordBox.Password != "123456")
                { textBlock2.Text = "Pogresan password!!!"; }
                else
                {
                    //ako sve okej prodje, otvara se forma za dezurnog radnika
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
            }

            //Login za supervizora
            if (checkBox.IsChecked != true && radioButton3.IsChecked == true)
            {
                if (textBox.Text != "merima")
                {
                    textBlock2.Text = "Pogresno korisnicko ime!!!";

                }
                else if (passwordBox.Password != "1234")
                { textBlock2.Text = "Pogresan password!!!"; }
                else
                {
                    //ako sve okej prodje, otvara se forma za supervizora
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
            //Forma za majstora
            if (checkBox.IsChecked != true && radioButton4.IsChecked == true)
            {
                if (textBox.Text != "sedin95")
                {
                    textBlock2.Text = "Pogresno korisnicko ime!!!";

                }
                else if (passwordBox.Password != "1234")
                { textBlock2.Text = "Pogresan password!!!"; }
                else
                {
                    //ako sve okej prodje, otvara se forma za supervizora
                    Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
                    if (window != null)
                    {
                        Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                        if (frame != null)
                        {
                            frame.Navigate((typeof(FormaIzvjestajMajstora)));
                        }
                    }
                }
            }
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
