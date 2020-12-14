using System.Collections.Generic;

namespace PracticeDependencyInversionPrinciple.Sample2.AfterDIP
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
