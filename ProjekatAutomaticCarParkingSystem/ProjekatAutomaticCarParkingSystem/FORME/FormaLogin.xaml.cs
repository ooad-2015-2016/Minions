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
        //vracamo se na proslu dugme natrag
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
            if (checkBox.IsChecked ==true)
            {
                textBlock2.Text = "Javite se vlasniku";
            }
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
                bool nadjen = false;
                foreach (Korisnik korisnik in KontejnerskaKlasa.korisnici)
                {
                    if (korisnik.Username == textBox.Text && korisnik.Password == passwordBox.Password)
                    {
                        nadjen = true;

                        Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
                        if (window != null)
                        {
                            Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                            if (frame != null)
                            {
                                frame.Navigate((typeof(FormaKorisnik)));
                            }
                        }
                    }

                }
                //ako se ne nadje ni jedan korisnik sa usernameom i pw znaci da je pogrijesio
                if (!nadjen) { textBlock2.Text = "Pogresan username ili password!!!"; }
            }
            //Login za majstora
            if (checkBox.IsChecked != true && radioButton4.IsChecked == true)
            {
                bool nadjen = false;
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
                if(!nadjen) textBlock2.Text = "Pogresan username ili password!!!";
            }
            
            if (checkBox.IsChecked != true && radioButton2.IsChecked == true)
            {
                bool nadjen = false;
                foreach (DezurniRadnik radnik in KontejnerskaKlasa.dezurniRadnici)
                {
                    if (radnik.Username == textBox.Text && radnik.Password == passwordBox.Password)
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

                }
                //ako se ne nadje ni jedan majstor sa usernameom i pw znaci da je pogrijesio
                if (!nadjen) textBlock2.Text = "Pogresan username ili password!!!";
                
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
