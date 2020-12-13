using System.Collections.Generic;

namespace PracticeDependencyInversionPrinciple.Sample2.BeforeDIP
{
    public class EmployeeManager
    {
        private List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public List<Employee> Employees => _employees;
    }
}
