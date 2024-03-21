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
    // Inherite Implemetation from GenericRepository<Department>  , Additional Method in IDepartmentRepository that is Needed 
    // To be Implemented Here
    public class DepartmentRepository : GenericRepository<Department> , IDepartmentRepository
    {
        private readonly AppDbContext context;

        public DepartmentRepository(AppDbContext context)  :base(context) 
        {
            this.context = context;
        }

        public IEnumerable<Department> Search(string DepartmentName)
          => context.Departments.Where(e => e.Name.Trim().ToLower()
            .Contains(DepartmentName.Trim().ToLower()));



        //public int Add(Department Department)
        //{
        //    context.Departments.Add(Department);
        //    return context.SaveChanges();
        //}

        //public int Delete(Department Department)
        //{
        //    context.Departments.Remove(Department);
        //    return context.SaveChanges();
        //}

        //public IEnumerable<Department> GetAll()
        //    => context.Departments.ToList();

        //public Department GetDepartmentById(int? id)
        //     => context.Departments.FirstOrDefault(d => d.Id == id);


        //public int Update(Department NewDepartment)
        //{
        //    context.Departments.Update(NewDepartment);
        //    return context.SaveChanges();
        //}
    }
}
