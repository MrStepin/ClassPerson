using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public static class OwnAssert
    {
        public static void Throws(Action action)
        {
            try
            {
                action();
            }
            catch
            {
                return;
            }

            throw new Exception();
        }
    }
}
