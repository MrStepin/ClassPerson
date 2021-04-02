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
        private Manager _manager;

        public Worker(Manager manager)
        {
            _manager = manager;
        }


        public double Salary { get; set; }
    }
}