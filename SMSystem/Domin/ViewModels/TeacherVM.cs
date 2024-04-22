using Domin.ViewModels;

namespace Domin.ViewModels
{
    public class TeacherVM: _AbsClassVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
