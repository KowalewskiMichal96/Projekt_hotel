using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_hotel
{
    partial class Guest
    {
        public override string ToString()
        {
            return LastName + " - " + DateOfBirth.ToString("dd/MM/yyy");
        }
    }

    partial class Payer
    {
        public override string ToString()
        {
            return Name + " - " + AccountNumber;
        }
    }

    partial class RoomType
    {
        public override string ToString()
        {
            return RoomName;
        }
    }
}
