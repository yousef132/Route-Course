using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Department : BaseEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Department Name is Required")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Department Code is Required")]

        public string Code { get; set; }

        public DateTime CreateAt { get; set; }   = DateTime.Now;//Default Value
    }
}
