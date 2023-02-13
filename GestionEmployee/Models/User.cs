using GestionEmployee.Core;

namespace GestionEmployee.Models
{
    public class User : Entity
    {
        public string login { get; set; }
        public string password { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}
