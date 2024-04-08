using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_MultiClass
{
    internal class ConstructorClass
    {
        private int value = 12;

        public ConstructorClass()
        {

        }

        public ConstructorClass(int newValue)
        {
            value =  newValue;
        }

        public ConstructorClass(int x, int y)
        {
            value = x * y;
        }

        public int getValue()
        {
            return value;
        }
    }
}
