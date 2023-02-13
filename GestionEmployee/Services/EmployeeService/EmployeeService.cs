using GestionEmployee.Data;
using GestionEmployee.Models;
using GestionEmployee.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
            private static List<Employee> employee = new List<Employee> {
        };

        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context; 
        }
        public async Task<List<Employee>> AddEmployee([FromBody] Employee employee1)
            {
                _context.Employees.Add(employee1);
                await _context.SaveChangesAsync();
                return employee;
            }

            public async Task<List<Employee>?> DeleteEmployee(int id)
            {
                var employee1 = await _context.Employees.FindAsync(id);
                if (employee1 == null)

                return null;

                _context.Employees.Remove(employee1);

                await _context.SaveChangesAsync();


            return employee;
            }

            public async Task<List<Employee>> GetAllEmployee()
            {
                var employee = await _context.Employees.ToListAsync();
                return employee;
            }

            public async Task<Employee?> GetSingleEmployee(int id)
            {
                var employee1 = _context.Employees.Find(id);
                if (employee1 == null)
                        return null;
                    return employee1;
            }

            public async Task<List<Employee>?> UpdateEmployee(int id, Employee request)
            {
                var employee1 = _context.Employees.Find(id);
                if (employee1 == null)
                        return null;

                    employee1.lastName = request.lastName;
                    employee1.firstName = request.firstName;
                    employee1.phone = request.phone;
                    employee1.cellPhone = request.cellPhone;
                    employee1.email = request.email;
                    employee1.ServiceId = request.ServiceId;
                    employee1.SiteId = request.SiteId;

                await _context.SaveChangesAsync();

                return employee;
            }
        }
    }

