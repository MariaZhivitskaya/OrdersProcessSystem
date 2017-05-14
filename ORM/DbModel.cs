using System.Data.Entity;

namespace ORM
{
    public class DbModel 
        : DbContext
    {
        public DbModel() : base("name=DbModel"){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Merchandise> Merchandises { get; set; }
        public DbSet<RequestMerchandise> RequestMerchandises { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
