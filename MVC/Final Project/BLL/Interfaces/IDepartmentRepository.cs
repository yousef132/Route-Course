using DAL.Entities;

namespace BLL.Interfaces
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        public IEnumerable<Department> Search(string DepartmentName);

    }
}
