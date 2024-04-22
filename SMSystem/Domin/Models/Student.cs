using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.Models
{
    public class Student: _AbsClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? CourseId { get; set; } //fk
        public int? ClassId { get; set; } //fk

        //Refrence property
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        [ForeignKey("ClassId")]
        public virtual Classes Classes { get; set; }

    }
}