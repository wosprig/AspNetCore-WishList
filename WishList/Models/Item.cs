using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public int Id;
        
        [Required]
        [MaxLength(50)]
        public string Description;
    }
}
