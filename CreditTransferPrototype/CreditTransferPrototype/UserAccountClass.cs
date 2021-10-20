using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditTransferPrototype
{
    class UserAccountClass
    {
        public int userID;
        public string userName;
        public string userPassword;
        public int accountNumber;
        public float accountCredit;
        public int mobileNumber;
        public string userFirstName;
        public string userMiddleName;
        public string userLastName;
        public string userEmail;

        public UserAccountClass(int userID, string userName, string userPassword, int accountNumber, float accountCredit, int mobileNumber, string userFirstName, string userMiddleName, string userLastName, string userEmail)
        {
            this.userID = userID;
            this.userName = userName;
            this.userPassword = userPassword;
            this.accountNumber = accountNumber;
            this.accountCredit = accountCredit;
            this.mobileNumber = mobileNumber;
            this.userFirstName = userFirstName;
            this.userMiddleName = userMiddleName;
            this.userLastName = userLastName;
            this.userEmail = userEmail;
        }

        public UserAccountClass()
        {
            this.userID = 0;
            this.userName = null;
            this.userPassword = null;
            this.accountNumber = 0;
            this.accountCredit = 0;
            this.mobileNumber = 0;
            this.userFirstName = null;
            this.userMiddleName = null;
            this.userLastName = null;
            this.userEmail = null;
        }

        public void ChangeAccountCredit(int amount)
        {
            this.accountCredit += amount;
        }
    }

}
