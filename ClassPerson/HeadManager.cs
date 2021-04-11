using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public class HeadManager : Manager
    {
        private List<Manager> ListOfManagers = new List<Manager>() { };

        private double _value;
        public double HeadManagerSalary
        {
            get
            {
                return _value;
            }
            set
            {
                foreach (Manager manager in ListOfManagers)
                {
                    if (manager.Salary >= value)
                    {
                        throw new Exception();
                    }
                }
                _value = value;
            }
        }
    }
}
