using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.DAL.models
{
    public class Phone
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Producer{ get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
