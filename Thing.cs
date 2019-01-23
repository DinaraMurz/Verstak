using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    public class Thing
    {
        public static int counter = 0;
        private string _name;
        private int _number;

        private int minusOne;
        Thing()
        {
            _name = "NoName";
            _number = minusOne;
        }

        Thing(string name, int number)
        {
            _name = name;
            _number = number;
        }
    }
}