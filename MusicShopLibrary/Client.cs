using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShopLibrary
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Client(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => $"{Id}---{FirstName} ,{LastName}";
    }
}
