using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsType
{
    internal class CustomCollection
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(string name, string surname, int age, double salary)
        {
            Employee employee = new Employee(name, surname, age, salary);
            employees.Add(employee);
        }

        public Employee FindEmployeeById(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public void PrintAllEmployees()
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Surname: {emp.Surname}, Age: {emp.Age}, Salary: {emp.Salary}");
            }
        }
    }
}

