using Domin.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.ViewModels
{
    public class StudentVM : _AbsClassVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CourseId { get; set; } //fk
        public int ClasseId { get; set; } //fk

        public CourseVM Course { get; set; }
    }
}