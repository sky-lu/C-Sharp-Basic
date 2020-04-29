using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ATMLib
{
    public class clsClient
    {
        private string vNumber;
        private string vName;
        private string vPin;
        private Dictionary<string, List<clsAccount>> vAccounts;


        public clsClient()
        {
            vNumber = vName = vPin = "Not defined";
            vAccounts = new Dictionary<string, List<clsAccount>>();
        }

        public clsClient(string aNumber, string aName)
        {
            Number = aNumber;
            Name = aName;
            Pin = "Not defined";
            vAccounts = new Dictionary<string, List<clsAccount>>();
        }
        public clsClient(string aNumber, string aName,  string aPin)
        {
            Number = aNumber;
            Name = aName;
            Pin = aPin;
            vAccounts = new Dictionary<string, List<clsAccount>>();
        }

        public Dictionary<string, List<clsAccount>> Accounts
        {
            get => vAccounts;
            set
            {
                vAccounts = value;
            }
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public string Number
        {
            get => vNumber;
            set
            {
                vNumber = value;
            }
        }

        public string Pin
        {
            get => vPin;
            set
            {
                vPin = value;
            }
        }

        public bool Create()
        {
            return false;
        }

        public string Display()
        {
            string info = " \nNumber: " + Number + " \nName: " + Name + " \nPin: "
                          + Pin + " \nAll the accounts of this client\n";
            //foreach (clsAccount account in Accounts.Values)
            //{
            //    info += 
            //}
            return info;
        }

        public void Fill()
        {
            StreamReader myFile = new StreamReader("Accounts.txt");
            while (!myFile.EndOfStream)
            {
                string AccountNumber = myFile.ReadLine();
                string ClientNumber = myFile.ReadLine();
                string type = myFile.ReadLine();
                Int16 day = Convert.ToInt16(myFile.ReadLine());
                Int16 month = Convert.ToInt16(myFile.ReadLine());
                Int16 year = Convert.ToInt16(myFile.ReadLine());
                decimal balance = Convert.ToDecimal(myFile.ReadLine());
                clsAccount account = new clsAccount(AccountNumber, type, day, month, year, balance);
                List<clsAccount> myAccount = new List<clsAccount>();
                myAccount.Add(account);
                if (Accounts.ContainsKey(ClientNumber))
                {
                    Accounts[ClientNumber].Add(account);
                }
                else {
                    
                    Accounts.Add(ClientNumber, myAccount);
                }
                account = null;
            }

            myFile.Close();
        }
    }
}