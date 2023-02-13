using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployee();
        Task<Employee?> GetSingleEmployee(int id);
        Task<List<Employee>> AddEmployee([FromBody] Employee employee1);
        Task<List<Employee>?> UpdateEmployee(int id, Employee request);
        Task<List<Employee>?> DeleteEmployee(int id);
    }
}
