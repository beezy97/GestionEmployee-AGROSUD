using GestionEmployee.Core;
using System.Text.Json.Serialization;

namespace GestionEmployee.Models
{
    public class Employee : Entity
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string phone { get; set; }
        public string cellPhone { get; set; }
        public string email { get; set; }


        public int ServiceId { get; set; }

        public int SiteId { get; set; }
    }
}
