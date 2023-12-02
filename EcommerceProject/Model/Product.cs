using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.Model
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public decimal Discount { get; set; } = decimal.Zero;
        public int CategoryID { get; set; }
        public DateTime RecordTimeStamp { get; set; } = DateTime.MinValue;
    }
}

