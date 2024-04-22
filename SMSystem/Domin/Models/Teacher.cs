using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domin.Models
{
    public class Teacher: _AbsClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Navigation Property

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
