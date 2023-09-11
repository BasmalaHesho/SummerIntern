using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Data.Entities
{
    public class Employee
    {

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public required string Position { get; set; }
        public required string Mail { get; set; }
        public double Salary { get; set; }
        public int Mobile { get; set; }
        public string? Gender { get; set; }

        public Guid DepId { get; set; }

        [ForeignKey(nameof(DepId))]
        public required Departmenets Departments { get; set; }

    }
}
