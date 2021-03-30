using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    public class Orders
    {
        private readonly List<Order> ListOfOrders;
        int counter = 1;

        public Orders()
        {
            this.ListOfOrders = new List<Order>();
        }

        public void AddNewOrder(int CID,List<string>Name,List<double> price)
        {
            Order o = new Order(counter, CID, Name, price);
            AddNewOrder(o);
        }

        private void AddNewOrder(Order o)
        {
            ListOfOrders.Add(o);
            counter++;
        }

        public void PrintOders()
        {
            foreach(Order O in ListOfOrders)
            {
                Console.WriteLine("|========================================|");
                Console.WriteLine($"|{O.IDOrder}|{O.IDClient}|Nazwa Produktu      |Cena |");
                for(int i = 0; i < O.OrderRecipe.Length; i++)
                {
                    Console.WriteLine($"    |{O.OrderRecipe[i]}|{O.OrderPrice[i]}|");
                }
                Console.WriteLine("|========================================|");
            }
        }
    }
}
