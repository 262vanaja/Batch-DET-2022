using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch_det_2022
{
    internal class EmployeeLinq
    {
        public static void Main()
        {
            SampleEmployeeList();
        }
        public class Employee
        {
            public Employee()
            {

            }

            public Employee(int id, string name, string dept)
            {
                this.ID = id;
                this.Name = name;
                this.Dept = dept;

            }
            public int ID { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }

        }
        private static List<Employee> GetListofEmployees()
        {
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee(1, "John", "Training"));
            emps.Add(new Employee(2, "Mark", "Finance"));
            emps.Add(new Employee(3, "Peter", "Technical"));
            emps.Add(new Employee(4, "Bob", "Technical"));
            emps.Add(new Employee(5, "Robert", "Finance"));
            emps.Add(new Employee(6, "Jason", "Training"));

            return emps;


        }
        private static void SampleEmployeeList()
        {
            List<Employee> emps = GetListofEmployees();
            var emp_query = from employee in emps
                            select employee;
            foreach (var item in emp_query)
            {
                Console.WriteLine("Name is " + item.Name + " and dept is " + item.Dept);

            }
            Console.ReadLine();
        }
    }
}


