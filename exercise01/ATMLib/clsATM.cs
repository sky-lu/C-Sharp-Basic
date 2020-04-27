using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ATMLib
{
    public class clsATM
    {
        private Dictionary<string, clsClient> vClients;
        private string vCompany;
        private string vNumber;

        public clsATM()
        {
            vNumber = vCompany = "Not defined";
            vClients = new Dictionary<string, clsClient>();
        }

        public clsATM(string aNumber)
        {
            Number = aNumber;
            Company = "Not defined";
            vClients = new Dictionary<string, clsClient>();
        }
        public clsATM(string aCompany, string aNumber)
        {
            Number = aNumber;
            Company = aCompany;
            vClients = new Dictionary<string, clsClient>();
        }

        public Dictionary<string, clsClient> Clients
        {
            get => vClients;
            set
            {
                vClients = value;
            }
        }

        public string Company
        {
            get => vCompany;
            set
            {
                vCompany = value;
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

        public string Display()
        {
            throw new System.NotImplementedException();
        }

        public void Fill()
        {
            StreamReader myFile = new StreamReader("Clients.txt");
            while (!myFile.EndOfStream)
            {
                string number = myFile.ReadLine();
                string name = myFile.ReadLine();
                string pin = myFile.ReadLine();
                clsClient client = new clsClient(number, name, pin);
                Clients.Add(client.Number, client);
                client = null;

            }
            myFile.Close();
        }
        public void Open()
        {
            throw new System.NotImplementedException();
        }
    }
}