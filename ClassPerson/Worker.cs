using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public class Worker : Employee
    {
        private double _managerSalary;
        private double _value;

        public void ManagerSalary(Manager manager)
        {
            _managerSalary = manager.Salary;
        }

        public double Salary
        {
            get
            {
                if (_managerSalary <= _value)
                {
                    throw new Exception("Increase salary!");
                }
                
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}
