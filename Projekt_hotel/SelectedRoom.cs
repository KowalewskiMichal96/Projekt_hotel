using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_hotel
{
    public class SelectedRoom
    {
        //private string _Name;
        public string Name
        {
            get;
            set;
        }
        public List<string> guests = new List<string>();

        public SelectedRoom(string NAME)
        {
            Name = NAME;
        }
    }
}
