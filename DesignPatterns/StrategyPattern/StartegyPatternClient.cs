using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class StartegyPatternClient
    {
        static void Main()
        {
            SortedEmployees sortedEmployeeObj = new SortedEmployees();
            sortedEmployeeObj.Add(new Employee() { Name = "M", Age = 24, Salary = 30000 });
            sortedEmployeeObj.Add(new Employee() { Name = "N", Age = 27, Salary = 32000 });
            sortedEmployeeObj.Add(new Employee() { Name = "J", Age = 23, Salary = 12000 });

            sortedEmployeeObj.SetSortStrategy(new SortByAge());
            sortedEmployeeObj.Sort();

            sortedEmployeeObj.SetSortStrategy(new SortByName());
            sortedEmployeeObj.Sort();

            sortedEmployeeObj.SetSortStrategy(new SortBySalary());
            sortedEmployeeObj.Sort();

        }
    }

    public interface ISort
    {
        IEnumerable<Employee> Sort(IEnumerable<Employee> employeeList);
    }

    public class SortByAge : ISort
    {
        public IEnumerable<Employee> Sort(IEnumerable<Employee> employeeList)
        {
            return employeeList.OrderBy(emp => emp.Age);
        }
    }

    public class SortByName : ISort
    {
        public IEnumerable<Employee> Sort(IEnumerable<Employee> employeeList)
        {
            return employeeList.OrderBy(emp => emp.Name);
        }
    }

    public class SortBySalary : ISort
    {
        public IEnumerable<Employee> Sort(IEnumerable<Employee> employeeList)
        {
            return employeeList.OrderBy(emp => emp.Salary);
        }
    }

    public class SortedEmployees
    {
        private ISort _sortStrategy;

        public List<Employee> employees = new List<Employee>();

        public void SetSortStrategy(ISort sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        public void Add(Employee emp)
        {
            employees.Add(emp);
        }

        public void Sort()
        {
            foreach(var employee in _sortStrategy.Sort(employees))
            {
                Console.WriteLine($"Employee name : {employee.Name}, Age: {employee.Age}, Salary:{employee.Salary}");
            }
        }
    }

    public class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
