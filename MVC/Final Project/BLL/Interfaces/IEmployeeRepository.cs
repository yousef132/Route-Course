using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        public IEnumerable<Employee> GetEmployeesByDepartmentName(string DepartmentName);
        public IEnumerable<Employee> Search(string EmployeeName);
        public void DestroyInstance(Employee employee);
	}
}
