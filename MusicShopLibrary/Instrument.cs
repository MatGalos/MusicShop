using System;
using System.Collections.Generic;
using System.Text;


namespace MusicShopLibrary
{
    public class Instrument : IProduct
    {
        public double Cena { get; private set; }
        public string Nazwa { get; private set; }
        public int Id { get; private set; }
        public string Producent { get; set; }

        public IRodzaj InstrumentTyp { get; set; }
        public interface IRodzaj
        {
            string TypInstrumentu();
        }

        public class Guitar : IRodzaj
        {
            public string TypInstrumentu()
            {
                return "Gitara";
            }
        }

        public class Perkusja : IRodzaj
        {
            public string TypInstrumentu()
            {
                return "Perkusja";
            }
        }

        public class Klawisze : IRodzaj
        {
            public string TypInstrumentu()
            {
                return "Keyboard";
            }
        }

        public Instrument(int id,string rodzaj,string nazwa,string producent, double cena)
        {
            Nazwa = SetNazwa(nazwa);
            this.Producent = producent;
            Cena = SetCena(cena);
            Id = SetId(id);
            InstrumentTyp = ChooseType(rodzaj);
        }

        private IRodzaj ChooseType(string rodzaj)
        {
            switch (rodzaj)
            {
                case "Gitara":
                    return new Guitar();
                case "Perkusja":
                    return new Perkusja();
                case "Keyboard":
                    return new Klawisze();
                default:
                    throw new ArgumentOutOfRangeException("nie ma takiego typu instrumentu w sklepie");
            }
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