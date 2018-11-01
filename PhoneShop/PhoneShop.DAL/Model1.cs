namespace PhoneShop.DAL
{
    using PhoneShop.DAL.models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        
        public Model1()
            : base("name=Model1")
        {
        }


         public virtual DbSet<Phone> Phones  { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}