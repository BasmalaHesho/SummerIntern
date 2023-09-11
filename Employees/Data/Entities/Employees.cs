namespace Employees.Data.Entities
{
    public class Employees
    {

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Position { get; set; }
        public string Mail { get; set; }
        public double Salary { get; set; }
        public int Mobile { get; set; }
        public string? Gender { get; set; }
    }
}
