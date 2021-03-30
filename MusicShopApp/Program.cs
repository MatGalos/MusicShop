using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using MusicShopLibrary;


namespace MusicShopApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Tworzenie Obiektów
            Clients Klienci = new Clients();
            Klienci.AddNewClient("Mateusz", "Galos");
            Klienci.AddNewClient("Mariusz", "Galos");
            Klienci.AddNewClient("olgierd", "Galos");
            Klienci.AddNewClient("ivan", "Galos");
            Albums Albumy = new Albums();
            Albumy.AddNewAlbums("After Hours", "The Weeknd");
            Albumy.AddNewAlbums("To pimp a butterfly", "Kendric Lamar");
            Albumy.AddNewAlbums("The Life Of Pablo", "Kanye West");
            Albumy.AddNewAlbums("The Money Store", "Death Grips");
            Instruments Instrumenty = new Instruments();
            Instrumenty.AddNewInstruments("Gitara","UKM-03945G", "Yamaha", 259.99);
            Instrumenty.AddNewInstruments("Gitara","FAE-4332G","Epiphone", 829.99);
            Instrumenty.AddNewInstruments("Gitara","MEA-A4325","Sterling", 3259.99);
            Instrumenty.AddNewInstruments("Keyboard","FSEW-123", "Yamaha", 599.99);
            Instrumenty.AddNewInstruments("Perkusja","TASFSA-12312", "Mapex", 1699.99);
            Accesories Akcesoria = new Accesories();
            Akcesoria.AddNewAccesories("Pianka akustyczna","Foamex",99.99);
            Orders Zamowienia = new Orders();
            Zamowienia.AddNewOrder(2, new List<string>() { "Gitara UKM-03945G Yamaha", "After Hours The Weeknd" }, new List<double> { 259.99, 29.99}); ;
            #endregion
            
            do
            {
                PrintMainMenu();
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 0:
                        //Zamykanie Terminala
                        Console.WriteLine("shutting down...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Klienci.PrintClients();
                        break;
                    case 2:
                        Klienci.AddNewClient(GetClientFirstName(), GetClientLastName()); 
                        break;
                    case 3:
                        Zamowienia.PrintOders();
                        break;
                    case 4:
                        PrepareNewOrder(Klienci,Albumy,Instrumenty,Akcesoria,Zamowienia);
                        break;
                    case 5:
                        AddNewProducts(Albumy, Instrumenty, Akcesoria);
                        break;
                    case 6:
                        ShowProducts(Albumy, Instrumenty, Akcesoria);
                        break;
                    case 7:
                        ModifyProducts(Albumy, Instrumenty, Akcesoria);
                        break;
                    case 8:
                        RemoveProducts(Albumy, Instrumenty, Akcesoria);
                        break;
                }
                
            } while (true);
        }


        private static void PrintMainMenu()
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Witaj sprzedawco!                             |");
            Console.WriteLine("|Co Chcesz dzisiaj zrobić?                     |");
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|0. Zamknij Terminal                           |");
            Console.WriteLine("|1. Wyświetl listę klientów                    |");
            Console.WriteLine("|2. Dodaj Klienta                              |");
            Console.WriteLine("|3. Wyświetl listę transakcji                  |");
            Console.WriteLine("|4. Wprowadź nową transakcję                   |");
            Console.WriteLine("|5. Dodaj Produkty                             |");
            Console.WriteLine("|6. Wyświetl Produkty                          |");
            Console.WriteLine("|7. Modyfikuj Produkty                         |");
            Console.WriteLine("|8. Usuń Produkty                              |");
            Console.WriteLine("|==============================================|");
        }
        #region Rzeczy Do Dodania klienta
        private static string GetClientFirstName()
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Podaj imię klienta                            |");
            Console.WriteLine("|==============================================|");
            string FirstName = Console.ReadLine();
            return FirstName;
        }

        private static string GetClientLastName()
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Podaj nazwisko klienta                        |");
            Console.WriteLine("|==============================================|");
            string LastName = Console.ReadLine();
            return LastName;
        }
        #endregion

        #region Rzeczy Do Dodania Albumu
        private static string GetAlbumTitle()
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Podaj Tytuł Albumu                            |");
            Console.WriteLine("|==============================================|");
            string ALbumTitle = Console.ReadLine();
            return ALbumTitle;
        }

        private static string GetAlbumArtist()
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Podaj Artystę                                 |");
            Console.WriteLine("|==============================================|");
            string ALbumTitle = Console.ReadLine();
            return ALbumTitle;
        }
        #endregion

        #region Rzeczy Do Dodania Instrumentu i akcesoriów
        private static string GetItemType()
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Podaj Rodzaj instrumentu                      |");
            Console.WriteLine("|==============================================|");
            string ALbumTitle = Console.ReadLine();
            return ALbumTitle;
        }
        private static string GetItemName()
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Podaj Nazwę Przedmiotu                        |");
            Console.WriteLine("|==============================================|");
            string ALbumTitle = Console.ReadLine();
            return ALbumTitle;
        }

        private static string GetProducent()
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Podaj Producenta                              |");
            Console.WriteLine("|==============================================|");
            string ALbumTitle = Console.ReadLine();
            return ALbumTitle;
        }

        private static Double GetPrice()
        { 
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Podaj Cenę                                    |");
            Console.WriteLine("|==============================================|");
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Double ALbumTitle = Double.Parse(Console.ReadLine());
            return ALbumTitle;
        }

        #endregion

        #region Rzeczy Do Dodania Transakcji

        private static void PrepareNewOrder(Clients klienci, Albums albumy, Instruments instrumenty, Accesories akcesoria, Orders zamowienia)
        {
            klienci.PrintClients();
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Czy klient jest zarejestrowany?               |");
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|1.Tak                                         |");
            Console.WriteLine("|2.nie                                         |");
            Console.WriteLine("|==============================================|");
            int FirstChoice = Convert.ToInt32(Console.ReadLine());
            List<string> nazwa = new List<string>();
            List<double> ceny = new List<double>();
            bool working = true;
            int SecondChoice=0;
            switch (FirstChoice)
            {                
                case 1:
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|Podaj Id klienta                              |");
                    Console.WriteLine("|==============================================|");
                    SecondChoice = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|Tworzenie nowego klienta                      |");
                    Console.WriteLine("|==============================================|");
                    klienci.AddNewClient(GetClientFirstName(), GetClientLastName());
                    SecondChoice = klienci.GetCounter();
                    break;
            }
            do
            {
                Console.WriteLine("|==============================================|");
                Console.WriteLine("|Jaką operację chcesz dokonać?                 |");
                Console.WriteLine("|==============================================|");
                Console.WriteLine("|1.Dodaj produkt do rachunku                   |");
                Console.WriteLine("|2.Zakończ                                     |");
                Console.WriteLine("|==============================================|");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Console.WriteLine("|==============================================|");
                        Console.WriteLine("|Z jakiej Kategorii chcesz dodać?              |");
                        Console.WriteLine("|==============================================|");
                        Console.WriteLine("|1.Albumy                                      |");
                        Console.WriteLine("|2.Instrumenty                                 |");
                        Console.WriteLine("|3.Akcesoria                                   |");
                        Console.WriteLine("|==============================================|");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        int id = 0;
                        switch (choice)
                        {
                            case 1:
                                albumy.PrintAlbums();
                                Console.WriteLine("|==============================================|");
                                Console.WriteLine("|Podaj id Produktu                             |");
                                Console.WriteLine("|==============================================|");
                                id = Convert.ToInt32(Console.ReadLine());
                                nazwa.Add(albumy.GetAlbumString(id));
                                ceny.Add(albumy.GetAlbumPrice(id));
                                break;
                            case 2:
                                instrumenty.PrintInstruments();
                                Console.WriteLine("|==============================================|");
                                Console.WriteLine("|Podaj id Produktu                             |");
                                Console.WriteLine("|==============================================|");
                                id = Convert.ToInt32(Console.ReadLine());
                                nazwa.Add(instrumenty.GetInstrumentsString(id));
                                ceny.Add(instrumenty.GetInstrumentsPrice(id));
                                break;
                            case 3:
                                akcesoria.PrintAccesories();
                                Console.WriteLine("|==============================================|");
                                Console.WriteLine("|Podaj id Produktu                             |");
                                Console.WriteLine("|==============================================|");
                                id = Convert.ToInt32(Console.ReadLine());
                                nazwa.Add(akcesoria.GetAccesoriesString(id));
                                ceny.Add(akcesoria.GetAccesoriesPrice(id));
                                break;
                        }
                        break;
                    case 2:
                        zamowienia.AddNewOrder(SecondChoice, nazwa, ceny);
                        working = false;
                        break;
                }

            } while (working);
        }

        #endregion

        #region Dodawanie Produktów
        private static void AddNewProducts(Albums albumy, Instruments instrumenty, Accesories akcesoria)
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Z jakiej Kategorii chcesz dodać Produkt?      |");
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|1.Albumy                                      |");
            Console.WriteLine("|2.Instrumenty                                 |");
            Console.WriteLine("|3.Akcesoria                                   |");
            Console.WriteLine("|==============================================|");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    albumy.AddNewAlbums(GetAlbumTitle(), GetAlbumArtist());
                    break;
                case 2:
                    instrumenty.AddNewInstruments(GetItemType(), GetItemName(), GetProducent(), GetPrice());
                    break;
                case 3:
                    akcesoria.AddNewAccesories(GetItemName(), GetProducent(), GetPrice());
                    break;
            }
        }
        #endregion

        #region Wyświetlanie Produktów
        private static void ShowProducts(Albums albumy, Instruments instrumenty, Accesories akcesoria)
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Z jakiej Kategorii chcesz Wyświetlić Produkty?|");
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|0.Wszystkie                                   |");
            Console.WriteLine("|1.Albumy                                      |");
            Console.WriteLine("|2.Instrumenty                                 |");
            Console.WriteLine("|3.Akcesoria                                   |");
            Console.WriteLine("|==============================================|");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    albumy.PrintAlbums();
                    instrumenty.PrintInstruments();
                    akcesoria.PrintAccesories();
                    break;
                case 1:
                    albumy.PrintAlbums();
                    break;
                case 2:
                    instrumenty.PrintInstruments();
                    break;
                case 3:
                    akcesoria.PrintAccesories();
                    break;
            }
        }
        #endregion

        #region Modyfikacja Produktów
        private static void ModifyProducts(Albums albumy, Instruments instrumenty, Accesories akcesoria)
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Z jakiej Kategorii chcesz zmodyfikować Produkt|");
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|1.Albumy                                      |");
            Console.WriteLine("|2.Instrumenty                                 |");
            Console.WriteLine("|3.Akcesoria                                   |");
            Console.WriteLine("|==============================================|");
            int choice = Convert.ToInt32(Console.ReadLine());
            int id = 0;
            switch (choice)
            {
                case 1:
                    albumy.PrintAlbums();
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|Podaj id Produktu                             |");
                    Console.WriteLine("|==============================================|");
                    id = Convert.ToInt32(Console.ReadLine());
                    albumy.ModifyAlbum(id);
                    break;
                case 2:
                    instrumenty.PrintInstruments();
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|Podaj id Produktu                             |");
                    Console.WriteLine("|==============================================|");
                    id = Convert.ToInt32(Console.ReadLine());
                    instrumenty.ModifyInstruments(id);
                    break;
                case 3:
                    akcesoria.PrintAccesories();
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|Podaj id Produktu                             |");
                    Console.WriteLine("|==============================================|");
                    id = Convert.ToInt32(Console.ReadLine());
                    akcesoria.ModifyAccesories(id);
                    break;
            }
        }
        #endregion

        #region Usuwanie Produktów
        private static void RemoveProducts(Albums albumy, Instruments instrumenty, Accesories akcesoria)
        {
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|Z jakiej Kategorii chcesz usunąć Produkt?     |");
            Console.WriteLine("|==============================================|");
            Console.WriteLine("|1.Albumy                                      |");
            Console.WriteLine("|2.Instrumenty                                 |");
            Console.WriteLine("|3.Akcesoria                                   |");
            Console.WriteLine("|==============================================|");
            int choice = Convert.ToInt32(Console.ReadLine());
            int id = 0;
            switch (choice)
            {
                case 1:
                    albumy.PrintAlbums();
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|Podaj id Produktu                             |");
                    Console.WriteLine("|==============================================|");
                    id = Convert.ToInt32(Console.ReadLine());
                    albumy.RemoveAlbum(id);
                    break;
                case 2:
                    instrumenty.PrintInstruments();
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|Podaj id Produktu                             |");
                    Console.WriteLine("|==============================================|");
                    id = Convert.ToInt32(Console.ReadLine());
                    instrumenty.RemoveInstruments(id);
                    break;
                case 3:
                    akcesoria.PrintAccesories();
                    Console.WriteLine("|==============================================|");
                    Console.WriteLine("|Podaj id Produktu                             |");
                    Console.WriteLine("|==============================================|");
                    id = Convert.ToInt32(Console.ReadLine());
                    akcesoria.RemoveAccesories(id);
                    break;
            }
        }
        #endregion
    }
}
