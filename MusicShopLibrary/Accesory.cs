using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    public class Accesory : IProduct
    {
        public double Cena { get; private set; }
        public string Nazwa { get; private set; }
        public int Id { get; private set; }
        public string Producent { get; set; }

        public Accesory(int id, string Rodzaj, string producent, double cena)
        {
            Nazwa = SetNazwa(Rodzaj);
            this.Producent = producent;
            Cena = SetCena(cena);
            Id = SetId(id);
        }
        public double GetCena()
        {
            return Cena;
        }

        public string GetNazwa()
        {
            return Nazwa;
        }
        public int GetId()
        {
            return Id;
        }

        public double SetCena(double v) => this.Cena = v;

        public int SetId(int id) => this.Id =id;

        public string SetNazwa(string a) => this.Nazwa = a;
    }
}
