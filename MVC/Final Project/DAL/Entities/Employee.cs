using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee: BaseEntity
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [Column(TypeName ="money")]
        public double Salary { get; set; }  
        public bool IsActive { get; set; }

        public DateTime HireDate { get; set; }  = DateTime.Now;
        [Required(ErrorMessage ="Must Select One Department")]

        [Display(Name="Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }  

        public string ImageUrl { get; set; }
    }
}
