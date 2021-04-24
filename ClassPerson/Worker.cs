using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public class Worker
    {
        private double _value;
        private Manager _manager;

        public string Name { get; set; }
        public int Age { get; set; }
        public double Seniority { get; set; }

        public Worker() { }

        public Worker(Manager manager)
        {
            _manager = manager;
        }

        public double Salary
        {
            get
            {
                return _value;
            }
            set
            {
                if (_manager != null)
                {
                    if (_manager.Salary <= value)
                    {
                        throw new Exception();
                    }

                    _value = value;
                }
            }
        }
    }
}