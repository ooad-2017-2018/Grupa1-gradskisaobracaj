using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PublicTrApphic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Aplikacija aplikacija = new Aplikacija();
        public static int brojac=0;

        public MainPage()
        {
            this.InitializeComponent();
            brojac++;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (brojac != 1)
            {
                aplikacija = (Aplikacija)e.Parameter;
            }
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SignUp), aplikacija);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tekstUsername.Text.Length==0 || tekstPassword.Text.Length==0)
            {
                var dialog = new MessageDialog("Niste unijeli username ili password!");
                await dialog.ShowAsync();
            }
            else
            {
                if (aplikacija.korisnici.Capacity == 0)
                {
                    var dialog = new MessageDialog("NIJE UNESEN NIJEDAN KORISNIK!");
                    await dialog.ShowAsync();
                    tekstPassword.Text = "";
                    tekstUsername.Text = "";
                }
                else
                {
                    Korisnik user = (Korisnik)aplikacija.korisnici.Find(k => k.Username.Equals(tekstUsername.Text));
                    if (user.Password == tekstPassword.Text)
                    {
                        var dialog = new MessageDialog("DOBRODOŠLI " + user.Username + "!");
                        await dialog.ShowAsync();
                        tekstPassword.Text = "";
                        tekstUsername.Text = "";
                    }
                    else if (user.Password != tekstPassword.Text)
                    {
                        var dialog = new MessageDialog("Password je netačan!");
                        await dialog.ShowAsync();
                        tekstPassword.Text = "";
                    }
                    else
                    {
                        var dialog = new MessageDialog("Korisnik ne postoji!");
                        await dialog.ShowAsync();
                        tekstPassword.Text = "";
                        tekstUsername.Text = "";
                    }
                }
            }
        }
    }
}
