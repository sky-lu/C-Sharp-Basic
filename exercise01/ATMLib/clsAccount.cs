using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLib
{
    public class clsAccount
    {
        private string vNumber;
        private clsDate vOpenDate;
        private string vType;
        private decimal vBalance;

        public clsAccount()
        {
            Balance = 0;
            Number = Type = "Not defined";
            OpenDate = new clsDate();
        }

        public clsAccount(string aNumber, string aType, Int16 aDay, Int16 aMonth, Int16 aYear, decimal aBalance)
        {
            Number = aNumber;
            Type = aType;
            Balance = aBalance;
            OpenDate = new clsDate(aDay, aMonth, aYear);
        }

        public decimal Balance
        {
            get => vBalance;
            set
            {
                vBalance = value;
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

        public clsDate OpenDate
        {
            get => vOpenDate;
            set
            {
                vOpenDate = value;
            }
        }

        public string Type
        {
            get => vType;
            set
            {
                vType = value;
            }
        }

        public string Consult()
        {
            return " NUMBER: " + Number + " \nTYPE: " + Type + " \nOPEN DATE: "
                   + OpenDate.Display() + " \nBALANCE: " + Balance.ToString();
        }

        public bool Deposit(Int16 temp)
        {
            if(temp >= 2 && temp <= 20000)
            {
                return true;
            }
            return false;

        }

        public bool Open(clsAccount aAccount)
        {
             
           
            return false;

        }

        public Int16 Withdraw(Int16 temp)
        {
            if(temp > Balance)
            {
                return 1;
            } else if(temp > 500)
            {
                return 2;
            }else if(temp < 20)
            {
                return 3;
            }else if (temp % 20 != 0)
            {
                return 4;
            }

            return 0;

        }
    }
}