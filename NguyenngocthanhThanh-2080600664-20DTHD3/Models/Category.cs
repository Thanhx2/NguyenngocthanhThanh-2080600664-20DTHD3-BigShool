using System.ComponentModel.DataAnnotations;

namespace NguyenngocthanhThanh_2080600664_20DTHD3.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}