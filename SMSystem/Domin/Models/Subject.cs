using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.Models
{
    public class Subject: _AbsClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TeacherId { get; set; } //fk
        public int? CourseId { get; set; } //fk

        //Refrence property
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}
