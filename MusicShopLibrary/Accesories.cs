using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    public class Accesories
    {
        private readonly List<Accesory> ListOfAccesories;
        int count = 1;

        public Accesories()
        {
            this.ListOfAccesories = new List<Accesory>();
        }

        public void AddNewAccesories(string rodzaj, string producent, Double cena)
        {
            Accesory a = new Accesory(count, rodzaj, producent, cena);
            AddNewAccesories(a);
        }

        public void AddNewAccesories(Accesory a)
        {
            ListOfAccesories.Add(a);
            count++;
        }

        public void PrintAccesories()
        {
            Console.WriteLine("|========================================|");
            Console.WriteLine("|Id|Nazwa produktu     |Producent   |Cena|");
            Console.WriteLine("|========================================|");
            for (int i = 0; i < ListOfAccesories.Count; i++)
            {
                Console.WriteLine($"|{ListOfAccesories[i].Id}|{ListOfAccesories[i].Nazwa}|{ListOfAccesories[i].Producent}|{ListOfAccesories[i].Cena}|");
            }
            Console.WriteLine("|========================================|");
        }

        public string GetAccesoriesString(int id)
        {
            string nazwa = "";
            foreach (Accesory a in ListOfAccesories)
            {
                if (a.Id == id)
                {
                    nazwa = $"{ListOfAccesories[id].Nazwa} {ListOfAccesories[id].Producent} ";
                }
            }
            return nazwa;
        }

        public double GetAccesoriesPrice(int id)
        {
            double nazwa = 0.00;
            foreach (Accesory a in ListOfAccesories)
            {
                if (a.Id == id)
                {
                    nazwa = ListOfAccesories[id].Cena;
                }
            }
            return nazwa;
        }

        public void RemoveAccesories(int id)
        {
            Accesory temp = new Accesory(0, "null", "null", 0.00);
            foreach (Accesory a in ListOfAccesories)
            {
                if (a.Id == id)
                {
                    temp = a;
                }
            }
            ListOfAccesories.Remove(temp);
        }

        public void ModifyAccesories(int id)
        {
            int temp = 0;
            Console.WriteLine("|========================================|");
            Console.WriteLine("|Na jaką cenę chcesz zmienić?            |");
            Console.WriteLine("|========================================|");
            double Price = double.Parse(Console.ReadLine());
            foreach (Accesory a in ListOfAccesories)
            {
                if (a.Id == id)
                {
                    temp = id;
                }
            }
            ListOfAccesories[temp - 1].SetCena(Price);
        }
    }
}
