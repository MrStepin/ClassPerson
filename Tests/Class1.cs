using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
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
            manager.Salary = 90;
            Action workerSalary = () => { worker1.Salary = 100; };
            OwnAssert.Throws(workerSalary);
        }

        [Test]
        public void CheckManagers()
        {
            Manager manager2 = new Manager();
            Manager manager = new Manager(manager2);
            Worker worker1 = new Worker(manager);
            manager2.Salary = 90;
            worker1.Salary = 10;
            manager.HireWorker(worker1);
            Action managerSalary = () => { manager.Salary = 100; };
            OwnAssert.Throws(managerSalary);
        }

        [Test]
        public void CheckHireWorker()
        {
            Manager manager = new Manager();
            Manager manager2 = new Manager();
            Worker worker1 = new Worker(manager);
            manager2.HireWorker(worker1);
            Assert.NotNull(worker1.Leader);
            OwnAssert.CheckLeader(worker1.Leader, manager2);
        }
    }
}