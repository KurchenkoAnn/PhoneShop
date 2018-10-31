using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.DAL.models
{
    public class Order
    {
        public int ID { get; set; }
        public User Customer { get; set; }
        public Phone Item { get; set; }
        public DateTime OrderTime { get; set; }

    }
}
