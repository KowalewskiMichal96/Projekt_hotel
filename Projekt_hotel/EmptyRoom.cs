using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_hotel
{
    public class EmptyRoom
    {
        private string _Name;
        private string _Type;
        private int _Capacity;
        private int _Floor;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        public int Capacity
        {
            get
            {
                return _Capacity;
            }
            set
            {
                _Capacity = value;
            }
        }

        public int Floor
        {
            get
            {
                return _Floor;
            }
            set
            {
                _Floor = value;
            }
        }
    }
}
