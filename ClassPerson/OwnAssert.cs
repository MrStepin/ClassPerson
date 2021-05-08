using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
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

        public static void CheckLeader(Manager managerLeader, Manager manager)
        {
            try
            {
                if (managerLeader != manager)
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
