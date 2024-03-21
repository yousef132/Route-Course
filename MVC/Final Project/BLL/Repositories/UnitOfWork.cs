using BLL.Interfaces;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;

        public IDepartmentRepository DepartmentRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }

        public UnitOfWork(AppDbContext appDbContext,
            IDepartmentRepository departmentRepository ,
            IEmployeeRepository employeeRepository)
        {
            this.appDbContext = appDbContext;
            // DepartmentRepository = new DepartmentRepository(appDbContext);
            DepartmentRepository = departmentRepository;
            //employeeRepository = new EmployeeRepository(appDbContext);
            EmployeeRepository = employeeRepository;
            
        }
        public int Complete()
        {
            return appDbContext.SaveChanges();
        }
    }
}
