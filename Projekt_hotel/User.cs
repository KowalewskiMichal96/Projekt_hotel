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

        public void SetData(int ID, char ROLE, string NAME)
        {
            Id = ID;
            Name = NAME;
            if(ROLE == 'U')
            {
                IsAdmin = false;
            }
            else if(ROLE == 'A')
            {
                IsAdmin = true;
            }
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

        public void SetFree()
        {
            Id = 0;
            IsAdmin = false;
            Name = "";

        }
    }
}
