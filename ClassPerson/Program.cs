using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            Worker worker3 = new Worker();

            Manager manager = new Manager();

            worker1.Name = "Mr.Ivan";
            worker1.Salary = 100;
            worker1.Age = 30;
            worker1.Seniority = 1;

            worker2.Name = "Mr.Oleg";
            worker2.Salary = 150;
            worker2.Age = 20;
            worker2.Seniority = 2;

            worker3.Name = "Mr.Vasya";
            worker3.Salary = 100;
            worker3.Age = 30;
            worker3.Seniority = 1;

            manager.Name = "Mr.Boss";
            manager.SetSalary(manager, 200);
            manager.Age = 40;
            manager.Seniority = 10;

            manager.Hire(worker1);
            manager.Hire(worker2);
            manager.Hire(worker3);

            manager.Dismiss(worker2);
        }
    }
}
