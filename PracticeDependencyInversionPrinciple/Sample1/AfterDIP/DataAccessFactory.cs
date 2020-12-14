namespace PracticeDependencyInversionPrinciple.Sample1.AfterDIP
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
