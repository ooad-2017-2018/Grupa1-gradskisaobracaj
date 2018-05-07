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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PublicTrApphic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignUp : Page
    {
        public string ime="";
        public string prezime="";
        public string jmbg="";
        public int opcija=0;
        public Aplikacija aplikacija;

        public SignUp()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            aplikacija = (Aplikacija)e.Parameter;
        }
    
    private void dugmeDalje_Click(object sender, RoutedEventArgs e)
        {
            ime = tekstIme.Text;
            prezime = tekstPrezime.Text;
            jmbg = tekstJMBG.Text;
            if (radiobStudent.IsChecked == true) opcija = 1;
            else if (radiobPenzioner.IsChecked == true) opcija = 2;
            else if (radiobZaposlen.IsChecked == true) opcija = 3;
            else if (radiobNezaposlen.IsChecked == true) opcija = 4;
            else opcija = 0;
            SignupParams parametri = new SignupParams(ime, prezime, jmbg, opcija, aplikacija);
            this.Frame.Navigate(typeof(SignUp2), parametri);
        }
    }
}
