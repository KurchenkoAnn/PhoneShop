namespace PhoneShop.DAL
{
    using PhoneShop.DAL.models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhoneContext : DbContext
    {

        public PhoneContext()
            : base("name=Model1")
        {
        }


        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
   
}