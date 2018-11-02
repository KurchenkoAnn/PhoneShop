using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.DAL.models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public User Customer { get; set; }
        [Required]
        public Phone Item { get; set; }
        [Required]
        public DateTime OrderTime { get; set; }

    }
}
