using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1.Contracts;

namespace WcfServiceLibrary1
{
 public   class EmailDTO
    {
      public  string email { get; set; }
      public string message { get; set; }
      public IUser user { get; set; }
    }
}
 