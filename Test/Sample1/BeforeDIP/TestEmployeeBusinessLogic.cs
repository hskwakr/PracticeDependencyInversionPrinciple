using Xunit;
using Xunit.Sdk;
using PracticeDependencyInversionPrinciple.Sample1.BeforeDIP;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System;

namespace Test.Sample1.BeforeDIP
{
    public class TestEmployeeBusinessLogic
    {
        public class CustomComperer<T> : IEqualityComparer<T>
        {
            public bool Equals([AllowNull] T expected, [AllowNull] T actual)
            {
                var props = typeof(T).GetProperties(
                    BindingFlags.DeclaredOnly |
                    BindingFlags.Public |
                    BindingFlags.Instance
                );

                foreach (var prop in props)
                {
                    var expectedValue = prop.GetValue(expected, null);
                    var actualValue = prop.GetValue(actual, null);

                    if (!expectedValue.Equals(actualValue))
                    {
                        throw new EqualException(
                            $"A value of \"{expectedValue}\" for property \"{prop.Name}\"",
                            $"A value of \"{actualValue}\" for property \"{prop.Name}\""
                        );
                    }
                }

                return true;
            }

            public int GetHashCode([DisallowNull] T parameterValue)
            {
                return Tuple.Create(parameterValue).GetHashCode();
            }
        }

        public class GetEmployeeDetailsMethod
        {
            [Fact]
            public void GetEmployeeDetails_Calculated()
            {
                EmployeeBusinessLogic logic = new EmployeeBusinessLogic();
                int id = 10;

                Employee expected = new Employee()
                {
                    ID = id,
                    Name = "Pranaya",
                    Department = "IT",
                    Salary = 10000
                };

                CustomComperer<Employee> comperer = new CustomComperer<Employee>();
                Assert.Equal(expected, logic.GetEmployeeDetails(id), comperer);
            }
        }
    }
}
