using System.Linq;

namespace PracticeDependencyInversionPrinciple.Sample2.BeforeDIP
{
    public class EmployeeStatistics
    {
        private EmployeeManager _empManager;

        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }

        public int CountFemaleManagers()
        {
            return _empManager.Employees.Count(emp => 
                emp.Gender == Gender.Female &
                emp.Position == Position.Manager
            );
        }
    }
}
