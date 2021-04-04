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
        public void CheckSalary()
        {
            Manager manager = new Manager();
            Worker worker1 = new Worker(manager);
            Worker worker2 = new Worker(manager);
            Worker worker3 = new Worker(manager);   
            manager.Hire(worker1);
            manager.Hire(worker2);
            manager.Hire(worker3);
            manager.Salary = 90;
            worker1.Salary = 100;

            OwnAssert.AssertMoreThan(worker1.Salary, manager.Salary);
        }
    }
}