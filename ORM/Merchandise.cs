using System.ComponentModel.DataAnnotations;

namespace ORM
{
    public class Merchandise
    {
        [Key]
        public int Id { get; set; }

        public int Amount { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}
