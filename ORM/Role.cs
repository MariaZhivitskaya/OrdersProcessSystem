using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ORM
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}