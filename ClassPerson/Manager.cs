using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public class Manager  : Worker
    {
        private double _value;

        private List<Worker> listOfWorkers = new List<Worker>() { };

        private List<Manager> listOfManagers = new List<Manager>() { };

        public Manager() { }

        public Manager(Manager manager)
        {
            Leader = manager;
        }

        private void CheckSalary<T>(double value, List<T> listOfEmployees) where T: Worker
        {
            if ((Leader != null) && (listOfEmployees.Count != 0))
            {
                if (Leader.Salary <= value)
                {
                    foreach (T worker in listOfEmployees)
                    {
                        if (worker.Salary >= value)
                        {
                            throw new Exception();
                        }
                    }
                    throw new Exception();
                }
            }
        }

        public override double Salary 
        {
            get
            {
                return _value;
            }
            set
            {
                CheckSalary(value, listOfWorkers);
                CheckSalary(value, listOfManagers);
                _value = value;
            }
        }

        public void DismissEmployee<T>(T worker, List<T> listOfEmployees)
        {
            listOfEmployees.Remove(worker);
        }

        private void HireEmployee<T>(T worker, List<T> listOfEmployees) where T : Worker
        {

            if (!listOfEmployees.Contains(worker))
            {
                if (worker.Leader != Leader)
                {
                    if (worker.Leader != null)
                    {
                        worker.Leader.DismissEmployee(worker, listOfEmployees);
                    }
                    worker.Leader = this;
                }
                listOfEmployees.Add(worker);
            }
        }

        public void HireWorker(Worker worker)
        {
            HireEmployee(worker, listOfWorkers);
        }

        public void HireManager(Manager manager)
        {
            HireEmployee(manager, listOfManagers);
        }
    }
}
