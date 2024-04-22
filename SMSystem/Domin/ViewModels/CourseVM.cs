using Domin.ViewModels;

namespace Domin.ViewModels
{
    public class CourseVM : _AbsClassVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentVM> Students { get; set; }
    }
}
