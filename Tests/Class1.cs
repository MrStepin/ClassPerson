using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  NUnit.Framework;
using ClassPerson;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void CheckAssertOnWorkerSalary()
        {
            Manager manager = new Manager();
            Worker worker1 = new Worker(manager);
            Worker worker2 = new Worker(manager);
            Worker worker3 = new Worker(manager);   
            manager.HireWorker(worker1);
            manager.HireWorker(worker2);
            manager.HireWorker(worker3);
            manager.Salary = 90;
            Action workerSalary = () => { worker1.Salary = 100; };
            OwnAssert.Throws(workerSalary);
        }

        [Test]
        public void CheckManagers()
        {

        }
    }
}