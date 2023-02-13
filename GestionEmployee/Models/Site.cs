using GestionEmployee.Core;

namespace GestionEmployee.Models
{
    public class Site : Entity
    {
        public string city { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
