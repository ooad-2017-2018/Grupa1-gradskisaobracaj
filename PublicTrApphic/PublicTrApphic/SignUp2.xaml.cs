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
        public string ime = "";
        public string prezime = "";
        public string jmbg = "";
        public int opcija = 0;
        public Aplikacija aplikacija;

        public SignUp2()
        {
            this.InitializeComponent();
            labela1.Visibility = Visibility.Collapsed;
            labela2.Visibility = Visibility.Collapsed;
            tekstDodatni1.Visibility = Visibility.Collapsed;
            tekstDodatni2.Visibility = Visibility.Collapsed;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SignupParams parametri = (SignupParams)e.Parameter;
            ime = parametri.ime;
            prezime = parametri.prezime;
            jmbg = parametri.jmbg;
            opcija = parametri.opcija;
            aplikacija = parametri.aplikacija;
            if (opcija == 1)
            {
                tekstDodatni1.Visibility = Visibility.Visible;
                tekstDodatni2.Visibility = Visibility.Visible;
                labela1.Visibility = Visibility.Visible;
                labela1.Text = "Index";
                labela2.Visibility = Visibility.Visible;
                labela2.Text = "Naziv fakulteta";
            }
            else if (opcija == 2)
            {
                tekstDodatni1.Visibility = Visibility.Visible;
                labela1.Visibility = Visibility.Visible;
                labela1.Text = "ID penzione";
            }
            else if (opcija == 3)
            {
                tekstDodatni1.Visibility = Visibility.Visible;
                tekstDodatni2.Visibility = Visibility.Visible;
                labela1.Visibility = Visibility.Visible;
                labela1.Text = "ID radne knjiž.";
                labela2.Visibility = Visibility.Visible;
                labela2.Text = "Naziv firme";
            }
            else if (opcija == 4)
            {
                tekstDodatni1.Visibility = Visibility.Visible;
                labela1.Visibility = Visibility.Visible;
                labela1.Text = "ID radne knjiž.";
            }
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
            else if (ime.Length == 0 || ime.Length < 2 || prezime.Length==0 || prezime.Length<4)
            {
                var dialog = new MessageDialog("Vratite se nazad i unesite fino podatke(GREŠKA U IMENU ILI PREZIMENU!)");
                await dialog.ShowAsync();
            }
            else if (jmbg.Length == 0 || jmbg.Length < 13)
            {
                var dialog = new MessageDialog("Vratite se nazad i unesite fino podatke(GREŠKA U JMBG-u!)");
                await dialog.ShowAsync();
            }
            else if (opcija == 0)
            {
                var dialog = new MessageDialog("Vratite se nazad i unesite fino podatke(GREŠKA NISTE ODABRALI NIJEDNU OPCIJU!)");
                await dialog.ShowAsync();
            }
            else if (opcija == 1 && (tekstDodatni1.Text.Length == 0 || tekstDodatni2.Text.Length == 0))
            {
                var dialog = new MessageDialog("GREŠKA NISTE UNIJELI POLJA INDEX ILI FAKULTET!");
                await dialog.ShowAsync();
            }
            else if (opcija == 2 && tekstDodatni1.Text.Length == 0)
            {
                var dialog = new MessageDialog("GREŠKA NISTE UNIJELI POLJE ID PENZIONE!");
                await dialog.ShowAsync();
            }
            else if (opcija == 3 && (tekstDodatni1.Text.Length == 0 || tekstDodatni2.Text.Length == 0))
            {
                var dialog = new MessageDialog("GREŠKA NISTE UNIJELI POLJA ID ILI FIRMU!");
                await dialog.ShowAsync();
            }
            else if (opcija == 4 && tekstDodatni1.Text.Length == 0)
            {
                var dialog = new MessageDialog("GREŠKA NISTE UNIJELI POLJE ID!");
                await dialog.ShowAsync();
            }
            else
            {
                if(opcija == 1)
                {
                    Student student = new Student(ime, prezime, TekstBroj.Text, jmbg, Convert.ToInt32(tekstDodatni1.Text), tekstDodatni2.Text);
                    aplikacija.AddStudenta(student);
                    slikaLicne.Source = null;
                    TekstBroj.Text = "";
                    var dialog = new MessageDialog("Korisnik uspješno unesen! Vaš username je: " + student.Username + "\nVaš password je: " + student.Password);
                    await dialog.ShowAsync();
                }
                else if (opcija == 2)
                {
                    Penzioner penzioner = new Penzioner(ime, prezime, TekstBroj.Text, jmbg, Convert.ToInt32(tekstDodatni1.Text));
                    aplikacija.AddPenzionera(penzioner);
                    slikaLicne.Source = null;
                    TekstBroj.Text = "";
                    var dialog = new MessageDialog("Korisnik uspješno unesen! Vaš username je: " + penzioner.Username + "\nVaš password je: " + penzioner.Password);
                    await dialog.ShowAsync();
                }
                else if (opcija == 3)
                {
                    Zaposlen zaposlen = new Zaposlen(ime, prezime, TekstBroj.Text, jmbg, Convert.ToInt32(tekstDodatni1.Text), tekstDodatni2.Text);
                    aplikacija.AddZaposlenog(zaposlen);
                    slikaLicne.Source = null;
                    TekstBroj.Text = "";
                    var dialog = new MessageDialog("Korisnik uspješno unesen! Vaš username je: " + zaposlen.Username + "\nVaš password je: " + zaposlen.Password);
                    await dialog.ShowAsync();
                }
                else if (opcija ==4)
                {
                    Nezaposlen nezaposlen = new Nezaposlen(ime, prezime, TekstBroj.Text, jmbg, Convert.ToInt32(tekstDodatni1.Text));
                    aplikacija.AddNezaposlenog(nezaposlen);
                    slikaLicne.Source = null;
                    TekstBroj.Text = "";
                    var dialog = new MessageDialog("Korisnik uspješno unesen! Vaš username je: " + nezaposlen.Username + "\nVaš password je: " + nezaposlen.Password);
                    await dialog.ShowAsync();
                }
                this.Frame.Navigate(typeof(MainPage), aplikacija);
            }
        }

        private void dugmeNazad_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack) Frame.GoBack();
        }
    }
}
