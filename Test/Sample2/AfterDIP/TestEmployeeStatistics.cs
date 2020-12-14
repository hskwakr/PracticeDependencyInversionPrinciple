using Xunit;
using PracticeDependencyInversionPrinciple.Sample2.AfterDIP;

namespace Test.Sample2.AfterDIP
{
    public class TestEmployeeStatistics
    {
        public class CountFemaleManagersMethod
        {
            [Fact]
            public void CountFemaleManagers_Calculated()
            {
                var manager = InputData.Init();
                var stats = new EmployeeStatistics(manager);

                int expected = 1;
                Assert.Equal(expected, stats.CountFemaleManagers());
            }
        }

        public class InputData
        {
            public static EmployeeManager Init()
            {
                var manager = new EmployeeManager();
                manager.AddEmployee(new Employee()
                {
                    Name = "m1",
                    Gender = Gender.Male,
                    Position = Position.Administrator
                });
                manager.AddEmployee(new Employee()
                {
                    Name = "m2",
                    Gender = Gender.Male,
                    Position = Position.Manager
                });
                manager.AddEmployee(new Employee()
                {
                    Name = "m3",
                    Gender = Gender.Male,
                    Position = Position.Executive
                });
                manager.AddEmployee(new Employee()
                {
                    Name = "f1",
                    Gender = Gender.Female,
                    Position = Position.Administrator
                });
                manager.AddEmployee(new Employee()
                {
                    Name = "f2",
                    Gender = Gender.Female,
                    Position = Position.Manager
                });
                manager.AddEmployee(new Employee()
                {
                    Name = "f3",
                    Gender = Gender.Female,
                    Position = Position.Executive
                });

                return manager;
            }
        }
    }
}
