using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public static class OwnAssert
    {
        public static void AssertMoreThan(double compareValue, double value)
        {
            if (compareValue >= value)
            {
                throw new ArgumentException();
            }
        }
    }
}
