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
    public sealed partial class TransferCreditPage : Page
    {
        public TransferCreditPage()
        {
            this.InitializeComponent();
        }

        private void ConfirmTransferButton_Click(object sender, RoutedEventArgs e)
        {
            int GivenAccountNumber;
            int GivenAmount;

            

            int test;

            bool accountNumberSuccess = int.TryParse(AccountNumberTypeBox.Text, out GivenAccountNumber);
            bool amountNumberSuccess = int.TryParse(EnterAmountTypeBox.Text, out GivenAmount);
            if (accountNumberSuccess)
            {
                if(amountNumberSuccess)
                {
                    App.recievingUser = FindAccountNumber(GivenAccountNumber);

                    App.currentUser.ChangeAccountCredit(-GivenAmount);
                    App.recievingUser.ChangeAccountCredit(GivenAmount);
                }
                else
                {
                    //Error Message "Not a valid amount
                    
                    //ContentDialog dlg = new ContentDialog()
                    //{
                    //    Title = "My Content Dialog:",
                    //    Content = "Operation completed!",
                    //    CloseButtonText = "Ok"
                    //};
                }


            }

            else
            {
                //Error Message Not a valid account number

                //ContentDialog dlg = new ContentDialog()
                //{
                //    Title = "My Content Dialog:",
                //    Content = "Operation completed!",
                //    CloseButtonText = "Ok"
                //};
            }





        }

        UserAccountClass FindAccountNumber(int accNumber)
        {
            var foundAccount = App.AllUsers.SingleOrDefault(UserAccountClass => UserAccountClass.accountNumber == accNumber);
            return foundAccount;
        }
    }


}
