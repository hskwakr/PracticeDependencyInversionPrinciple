namespace PracticeDependencyInversionPrinciple.Sample1.BeforeDIP
{
    public class EmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };

            return emp;
        }
    }
}
