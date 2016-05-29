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
    public sealed partial class FormaSupervizor : Page
    {
        public FormaSupervizor()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Windows.UI.Xaml.Window window = Windows.UI.Xaml.Window.Current;
            if (window != null)
            {
                Windows.UI.Xaml.Controls.Frame frame = window.Content as Windows.UI.Xaml.Controls.Frame;
                if (frame != null)
                {
                    frame.Navigate((typeof(FORME.FormaDodajRadnika)));
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
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

    }
}
