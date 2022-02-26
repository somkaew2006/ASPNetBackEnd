using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETLIVE.Models
{
    //[Table("categories")]
    public class Category
    {
        //[Column("cat_id")]
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        //[Column(TypeName ="ntext")]
        [Required(ErrorMessage ="ชื่อประเภทสินค้า ห้ามว่าง")]
        public string CategoryName { get; set; } = null!;

        public bool IsActive { get; set; } = true;

    }
}
