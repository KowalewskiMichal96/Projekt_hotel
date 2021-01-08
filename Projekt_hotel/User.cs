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

        public void SetRole(int ID, char X)
        {
            Id = ID;
            if(X == 'U')
            {
                IsAdmin = false;
            }
            else if(X == 'A')
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
    }
}
