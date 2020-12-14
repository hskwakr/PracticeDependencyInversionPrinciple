namespace PracticeDependencyInversionPrinciple.Sample2.BeforeDIP
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum Position
    {
        Administrator,
        Manager,
        Executive
    }

    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }
}
