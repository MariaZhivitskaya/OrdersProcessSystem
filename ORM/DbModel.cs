using System.Data.Entity;

namespace ORM
{
    public class DbModel 
        : DbContext
    {
        public DbModel() : base("name=DbModel"){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
