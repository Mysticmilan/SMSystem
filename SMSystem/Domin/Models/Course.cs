using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domin.Models
{
    public class Course: _AbsClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation 
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
