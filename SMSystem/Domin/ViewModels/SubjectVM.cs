using Domin.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domin.ViewModels
{
    public class SubjectVM: _AbsClassVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; } //fk
        public int CourseId { get; set; } //fk
    }
}
