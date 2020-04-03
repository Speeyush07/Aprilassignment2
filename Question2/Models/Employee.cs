using System;
using System.Collections.Generic;

namespace ques_two.Models
{
    public class Employee
    {

        public int id { get; set; }
        public string name { get; set; }

        public Employee()
        {

        }

        public List<Employee> get()
        {


            List<Employee> emp = new List<Employee>()
        {
            new Employee{id=1,name="arsh" },
            new Employee{ id=2,name="abhay"},
            new Employee{id=3,name="nikhil"},
            new Employee{id=4,name="piyush"}

        };

            return emp;
        }
    }
}
