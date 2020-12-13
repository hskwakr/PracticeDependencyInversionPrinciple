namespace PracticeDependencyInversionPrinciple.Sample1.BeforeDIP
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
