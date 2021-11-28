using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
