namespace Domin.Models
{
    public abstract class _AbsClass
    {
        public int? CreatedBy { get; set; }  
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? UpdatedDate { get; set;}
        public int Status { get; set;}
    }
}
