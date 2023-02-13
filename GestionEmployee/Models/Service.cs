using GestionEmployee.Core;

namespace GestionEmployee.Models
{
    public class Service : Entity
    {
        public string name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
