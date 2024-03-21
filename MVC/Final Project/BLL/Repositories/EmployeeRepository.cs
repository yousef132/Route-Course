using BLL.Interfaces;
using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
    {
        private readonly AppDbContext _context;   
        public EmployeeRepository(AppDbContext context):base(context)
        {
            _context = context;
        }

		public void DestroyInstance(Employee employee)
		{
            _context.Entry(employee).State = EntityState.Detached;
		}

		public IEnumerable<Employee> GetEmployeesByDepartmentName(string DepartmentName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Search(string EmployeeName)
            => _context.Employees.Where(e=>e.Name.Trim().ToLower()
            .Contains(EmployeeName.Trim().ToLower()));

        //public int Add(Employee employee)
        //{
        //     _context.Employees.Add(employee);  
        //    return _context.SaveChanges();
        //}

        //public int Delete(Employee employee)
        //{
        //    _context.Employees.Remove(employee);
        //    return _context.SaveChanges();
        //}

        //public IEnumerable<Employee> GetAll()
        //{
        //    return _context.Employees.ToList();
        //}

        //public Employee GetEmployeeById(int id)
        //{
        //    return _context.Employees.FirstOrDefault(e => e.Id == id);
        //}



        //public int Update(Employee employee)
        //{
        //    _context.Employees.Update(employee);
        //    return _context.SaveChanges();
        //}
    }
}
