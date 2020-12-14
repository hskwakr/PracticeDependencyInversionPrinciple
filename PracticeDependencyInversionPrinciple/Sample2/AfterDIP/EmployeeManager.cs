using System.Collections.Generic;
using System.Linq;

namespace PracticeDependencyInversionPrinciple.Sample2.AfterDIP
{
    public class EmployeeManager : IEmployeeSearchable
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

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
        {
            return _employees.Where(emp =>
                emp.Gender == gender &
                emp.Position == position
            );
        }
    }
}
