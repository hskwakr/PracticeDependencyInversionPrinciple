using System.Linq;

namespace PracticeDependencyInversionPrinciple.Sample2.AfterDIP
{
    public class EmployeeStatistics
    {
        private IEmployeeSearchable _emp;

        public EmployeeStatistics(EmployeeManager empManager)
        {
            _emp = empManager;
        }

        public int CountFemaleManagers()
        {
            return _emp.GetEmployeesByGenderAndPosition(
                Gender.Female,Position.Manager
            ).Count();
        }
    }
}
