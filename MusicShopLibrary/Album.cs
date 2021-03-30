using System;

namespace MusicShopLibrary
{
    public class Album : IProduct
    {
        public string _nazwa;
        public string artysta;
        public double _cena;
        public int _id;
        public Album(string tytul, string artysta,int id)
        {
            _nazwa =SetNazwa(tytul);
            _cena =SetCena(29.99);
            this.artysta = artysta;
            _id =SetId(id);

        }

        public double GetCena()
        {
            return _cena;
        }

        public string GetNazwa()
        {
            return _nazwa;
        }

        public string GetArtistName()
        {
            return artysta;
        }

        public double SetCena(double v) => this._cena = v;
        public string SetNazwa(string a) => this._nazwa = a;
        public int SetId(int id) => this._id = id;


        public int GetId()
        {
            return _id;
        }

        int IProduct.GetId()
        {
            throw new NotImplementedException();
        }
    }

}
