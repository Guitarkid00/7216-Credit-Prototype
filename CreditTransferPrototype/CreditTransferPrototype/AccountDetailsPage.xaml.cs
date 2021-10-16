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
    public sealed partial class AccountDetailsPage : Page
    {

        
        public AccountDetailsPage()
        {

            this.InitializeComponent();

            User_Full_Name.Text = App.currentUser.userFirstName + " " + App.currentUser.userMiddleName + " " + App.currentUser.userLastName;
            User_Account_Number.Text = "Account Number: " + App.currentUser.accountNumber.ToString();
            User_Email.Text = App.currentUser.userEmail;
            User_Account_Credit.Text = "Account Credit: $" + App.currentUser.accountCredit.ToString();
            User_Mobile_Number.Text = App.currentUser.mobileNumber.ToString();
        }
    }
}
