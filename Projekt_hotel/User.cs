using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_hotel
{

    public class User
    {
        private int Id;
        private bool IsAdmin;
        private string Name;

        public User(int ID, char ROLE, string NAME)
        {
            Id = ID;
            Name = NAME;
            IsAdmin = ROLE == 'A' ?  true : false;
        } 

        public int GetId()
        {
            return Id;
        }
        public bool GetRole()
        {
            return IsAdmin;
        }
        public string GetName()
        {
            return Name;
        }

    }
}
