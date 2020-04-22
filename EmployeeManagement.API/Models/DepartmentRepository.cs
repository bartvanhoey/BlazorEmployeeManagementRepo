using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.API.Models;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _dbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public Department GetDepartment(int departmentId)
        {
            return _dbContext.Departments
                .FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _dbContext.Departments;
        }
    }
}