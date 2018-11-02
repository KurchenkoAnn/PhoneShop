using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1.Contracts;

namespace WcfServiceLibrary1.Services
{
    class Context : IOrder, IPhone, IUser
    {
        public List<OrderDTO> GetOrder()
        {
            UserDTO s = new UserDTO();
            s.Name = "Ragul";
            s.Email = "Ragul@.com";
            PhoneDTO phone = new PhoneDTO();
            phone.Model = "S";
            phone.Price = 50;
            phone.Producer = "C";
            List<OrderDTO> o = new List<OrderDTO>() { new OrderDTO { Customer = s, Item = phone } };
            return o;
        }

        public List<PhoneDTO> GetPhone()
        {
            List<PhoneDTO> p = new List<PhoneDTO>() { new PhoneDTO { Model = "Samsung govno", Producer = "China", Price = 5 } };
            return p;
        }

        public List<UserDTO> GetUser()
        {
            List<UserDTO> s = new List<UserDTO>(){ new UserDTO { Email = "dfd", Name = "dfds" }};

            return s;
        }
    }
}
