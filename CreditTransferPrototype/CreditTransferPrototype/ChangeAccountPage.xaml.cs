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

namespace CreditTransferPrototype
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChangeAccountPage : Page
    {
        public ChangeAccountPage()
        {
            this.InitializeComponent();
            if(App.currentUser == App.User001)
            {
                User001Button.IsEnabled = false;
                User002Button.IsEnabled = true;
            }
            else
            {
                User001Button.IsEnabled = true;
                User002Button.IsEnabled = false;
            }
        }

        private void User001Button_Click(object sender, RoutedEventArgs e)
        {
            App.currentUser = App.User001;
            User001Button.IsEnabled = false;
            User002Button.IsEnabled = true;
        }

        private void User002Button_Click(object sender, RoutedEventArgs e)
        {
            App.currentUser = App.User002;
            User001Button.IsEnabled = true;
            User002Button.IsEnabled = false;
        }
    }
}
