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

        public string Name { get; set; }
        public int Age { get; set; }
        public double Seniority { get; set; }
        public Manager Leader { get; set; }

        public Worker() { }

        public Worker(Manager manager)
        {
            Leader = manager;
        }

        public virtual double Salary
        {
            get
            {
                return _value;
            }
            set
            {
                if (Leader != null)
                {
                    if ((Leader.Salary <= value) && (Leader.Salary != 0))
                    {
                        throw new Exception();
                    }
                }
                _value = value;
            }
        }
    }
}