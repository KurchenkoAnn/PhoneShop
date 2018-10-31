using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class OrderUI
    {
        public int ID { get; set; }
        public UserUI Customer{get;set;}
        public PhoneUI Item { get; set; }
        public DateTime GetOrder { get; set; }
    }
}
