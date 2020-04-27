using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLib
{
    public class clsClient
    {
        private string vNumber;
        private string vName;
        private string vPin;
        private Dictionary<string, clsAccount> vAccounts;


        public clsClient()
        {
            vNumber = vName = vPin = "Not defined";
            vAccounts = new Dictionary<string, clsAccount>();
        }

        public clsClient(string aNumber, string aName)
        {
            Number = aNumber;
            Name = aName;
            Pin = "Not defined";
            vAccounts = new Dictionary<string, clsAccount>();
        }
        public clsClient(string aNumber, string aName,  string aPin)
        {
            Number = aNumber;
            Name = aName;
            Pin = aPin;
            vAccounts = new Dictionary<string, clsAccount>();
        }

        public Dictionary<string, clsAccount> Accounts
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
            return " WELCOME, " + Name;
        }
    }
}