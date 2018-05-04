using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PublicTrApphic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignUp2 : Page
    {
        public SignUp2()
        {
            this.InitializeComponent();
            //TekstBroj.IsEnabled = false;
        }

        private void Image_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            if (Frame.CanGoBack) Frame.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text+= "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TekstBroj.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string broj="";
            for(int i=0; i<TekstBroj.Text.Length-1; i++)
            {
                broj += TekstBroj.Text[i];
            }
            TekstBroj.Text = broj;
        }

        private async void Button_Click_11(object sender, RoutedEventArgs e)
        {
            var filePicker = new Windows.Storage.Pickers.FileOpenPicker();
            filePicker.FileTypeFilter.Add(".jpg");
            filePicker.FileTypeFilter.Add(".jpeg");
            filePicker.FileTypeFilter.Add(".png");
            Windows.Storage.StorageFile file;
           
            file = await filePicker.PickSingleFileAsync();

            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            var bitmapImage = new Windows.UI.Xaml.Media.Imaging.BitmapImage();
            await bitmapImage.SetSourceAsync(stream);
            slikaLicne.Source = bitmapImage;
        }

        private async void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (TekstBroj.Text.Length == 0 || TekstBroj.Text.Length < 9)
            {
                var dialog = new MessageDialog("Niste unijeli koretno broj!");
                await dialog.ShowAsync();
            }
            else
            {
                slikaLicne.Source = null;
                TekstBroj.Text = "";
                var dialog = new MessageDialog("Korisnik uspješno unesen!");
                await dialog.ShowAsync();
                this.Frame.Navigate(typeof(MainPage));
            }
        }
    }
}
