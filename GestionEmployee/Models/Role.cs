using GestionEmployee.Core;

namespace GestionEmployee.Models
{
    public class Role : Entity
    {
        public string name { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
