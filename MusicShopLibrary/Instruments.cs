using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    public class Instruments
    {
        private readonly List<Instrument> ListOfInstruments;
        int count = 1;

        public Instruments()
        {
            this.ListOfInstruments = new List<Instrument>();
        }

        public void AddNewInstruments(string typ,string nazwa,string producent,Double cena)
        {
            Instrument i = new Instrument(count,typ, nazwa, producent, cena);
            AddNewInstruments(i);
        }

        public void AddNewInstruments(Instrument i)
        {
            ListOfInstruments.Add(i);
            count++;
        }

        public void PrintInstruments()
        {
            Console.WriteLine("|========================================|");
            Console.WriteLine("|Id|Rodzaj  |Nazwa     |Producent   |Cena|");
            Console.WriteLine("|========================================|");
            for (int i = 0; i < ListOfInstruments.Count; i++)
            {
                Console.WriteLine($"{ListOfInstruments[i].Id}---{ListOfInstruments[i].InstrumentTyp.TypInstrumentu()},{ListOfInstruments[i].Nazwa} ,{ListOfInstruments[i].Producent}---- cena:{ListOfInstruments[i].Cena}");
            }
            Console.WriteLine("|========================================|");
        }

        public string GetInstrumentsString(int id)
        {
            string nazwa = "";
            foreach (Instrument a in ListOfInstruments)
            {
                if (a.Id == id)
                {
                    nazwa = $"{ListOfInstruments[id].InstrumentTyp} {ListOfInstruments[id].Nazwa} {ListOfInstruments[id].Producent}";
                }
            }
            return nazwa;
        }

        public double GetInstrumentsPrice(int id)
        {
            double nazwa = 0.00;
            foreach (Instrument a in ListOfInstruments)
            {
                if (a.Id == id)
                {
                    nazwa = ListOfInstruments[id].Cena;
                }
            }
            return nazwa;
        }

        public void RemoveInstruments(int id)
        {
            Instrument temp=new Instrument(0, "Gitara", "null", "null",0.00);
            foreach (Instrument a in ListOfInstruments)
            {
                if (a.Id == id)
                {
                    temp = a;
                }
            }
            ListOfInstruments.Remove(temp);
        }

        public void ModifyInstruments(int id)
        {
            int temp = 0;
            Console.WriteLine("|========================================|");
            Console.WriteLine("|Na jaką cenę chcesz zmienić?            |");
            Console.WriteLine("|========================================|");
            double Price = double.Parse(Console.ReadLine());
            foreach (Instrument a in ListOfInstruments)
            {
                if (a.Id == id)
                {
                    temp = id;
                }
            }
            ListOfInstruments[temp - 1].SetCena(Price);
        }
    }
}
