using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    class Order
    {
        public int IDOrder;
        public int IDClient;
        public string[] OrderRecipe;
        public double[] OrderPrice;

        public Order(int OID, int CID, List<string> Reci,List<double> cost)
        {
            this.IDOrder = OID;
            this.IDClient = CID;
            this.OrderRecipe = SetOrderRecepie(Reci);
            this.OrderPrice = SetPriceRecepie(cost);
        }

        private double[] SetPriceRecepie(List<double> cost)
        {
            List<double> a = new List<double>();
            double suma = 0.00;
            foreach(double d in cost)
            {
                a.Add(d);
                suma += d;
            }
            a.Add(suma);
            return a.ToArray();
        }

        private string[] SetOrderRecepie(List<string> reci)
        {
            List<string> a = new List<string>();
            foreach(string s in reci)
            {
                a.Add(s);
            }
            a.Add("Należność: ");
            return a.ToArray(); 
        }
    }
}
