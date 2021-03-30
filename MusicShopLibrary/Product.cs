using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    public interface IProduct
    {
        string GetNazwa();
        Double GetCena();
        int GetId();
        double SetCena(double v);
        string SetNazwa(string a);
        int SetId(int id);
    }

}
