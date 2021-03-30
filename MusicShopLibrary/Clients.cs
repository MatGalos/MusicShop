using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    public class Clients
    {
        private readonly List<Client> ListOfClients;
        int counter = 1;
        public Clients()
        {
            this.ListOfClients = new List<Client>();
        }
        public void AddNewClient(string firstName,string lastName)
        {
            Client c = new Client(counter, firstName, lastName);
            AddNewClient(c);
        }

        public void AddNewClient(Client c) {
            if (IsClientHere(c.FirstName, c.LastName) == false)
            {
                ListOfClients.Add(c);
                counter++;
            }
            else Console.WriteLine("Klient o takim imieniu i nazwisku już istnieje"); 
        }

        public void PrintClients()
        {
            Console.WriteLine("|========================================|");
            Console.WriteLine("|Id|Imię               |Nazwisko         |");
            Console.WriteLine("|========================================|");
            for (int i = 0; i < ListOfClients.Count; i++)
            {
                Console.WriteLine($"|{ListOfClients[i].Id}|{ListOfClients[i].FirstName}|{ListOfClients[i].LastName}|");
            }
            Console.WriteLine("|========================================|");
        }

        private bool IsClientHere(string firstName, string lastName)
        {
            bool results = false;
            for(int i = 0; i < ListOfClients.Count; i++)
            {
                if (ListOfClients[i].FirstName == firstName && ListOfClients[i].LastName == lastName) results = true; break;
            }
            return results;

        }

        public int GetCounter()
        {
            return counter;
        }
    }
}
