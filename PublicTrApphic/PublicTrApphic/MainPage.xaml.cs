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
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SignUp));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tekstUsername.Text.Length==0 || tekstPassword.Text.Length==0)
            {
                var dialog = new MessageDialog("Niste unijeli username ili password!");
                await dialog.ShowAsync();
            }
            //else if
            else
            {
                tekstPassword.Text = "";
                tekstUsername.Text = "";
                BlinkPopup.Begin();
                PopupTextBlock.Visibility = Visibility.Visible;
            }
        }


    }
}
