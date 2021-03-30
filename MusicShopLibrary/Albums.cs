using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    public class Albums
    {
        private List<Album> ListOfAlbums;
        int counter = 1;

        public Albums()
        {
            this.ListOfAlbums = new List<Album>();
        }

        public void AddNewAlbums(string tytul,string artysta)
        {
            Album a = new Album(tytul,artysta,counter);
            AddNewAlbums(a);
        }

        private void AddNewAlbums(Album a)
        {
            ListOfAlbums.Add(a);
            counter++;
        }

        public void PrintAlbums()
        {
            Console.WriteLine("|========================================|");
            Console.WriteLine("|Id|Nazwa produktu     |Wykonawca   |Cena|");
            Console.WriteLine("|========================================|");
            for (int i = 0; i < ListOfAlbums.Count; i++)
            {
                Console.WriteLine($"|{ListOfAlbums[i]._id}|{ListOfAlbums[i]._nazwa}|{ListOfAlbums[i].artysta}|{ListOfAlbums[i]._cena}|");
            }
            Console.WriteLine("|========================================|");
        }

        public string GetAlbumString(int id)
        {
            string nazwa="";
            foreach (Album a in ListOfAlbums)
            {
                if (a._id == id)
                {
                    nazwa = $"{ListOfAlbums[id]._nazwa} {ListOfAlbums[id].artysta}";
                }
            }
            return nazwa;
        }

        public double GetAlbumPrice(int id)
        {
            double nazwa = 0.00;
            foreach (Album a in ListOfAlbums)
            {
                if (a._id == id)
                {
                    nazwa = ListOfAlbums[id]._cena;
                }
            }
            return nazwa;
        }

        public void RemoveAlbum(int id)
        {
            Album temp = new Album( "null", "null",0);
            foreach (Album a in ListOfAlbums)
            {
                if (a._id == id)
                {
                    temp = a;
                }
            }
            ListOfAlbums.Remove(temp);
        }

        public void ModifyAlbum(int id)
        {
            int temp = 0;
            Console.WriteLine("|========================================|");
            Console.WriteLine("|Na jaką cenę chcesz zmienić?            |");
            Console.WriteLine("|========================================|");
            double Price = double.Parse(Console.ReadLine());
            foreach (Album a in ListOfAlbums)
            {
                if (a._id == id)
                {
                    temp = id;
                }
            }
            ListOfAlbums[temp-1]._cena = Price;
        }
    }
}
