namespace PracticeDependencyInversionPrinciple.Sample1.BeforeDIP
{
    public class EmployeeBusinessLogic
    {
        private EmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
