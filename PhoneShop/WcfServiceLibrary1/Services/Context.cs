using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1.Contracts;

using System.Net.Mail;
using System.Net;

namespace WcfServiceLibrary1.Services
{
    class Context : IOrder, IPhone, IUser,IEmail
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
            List<PhoneDTO> p = new List<PhoneDTO>() { new PhoneDTO { Model = "Samsung govno", Producer = "Sumsung", Price = 5 } };
            return p;
        }

        public List<UserDTO> GetUser()
        {
            List<UserDTO> s = new List<UserDTO>(){ new UserDTO { Email = "d", Name = "vAsyan" }};

            return s;
        }

        SmtpClient smtpClient = new SmtpClient();
        public void SendOnEmail(string subject, string Messege, UserDTO user)
        {
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(@"GovnoMagaz@gmail.com", "okun1234");
            MailAddress mailAddress = new MailAddress(@"GovnoMagaz@gmail.com");
            MailMessage m = new MailMessage();
            m.From = mailAddress;
            m.To.Add(user.Email);
            m.Subject = subject;
            m.Body = Messege;
            smtpClient.EnableSsl = true;
            smtpClient.Send(m);


        }

       
    }
}
