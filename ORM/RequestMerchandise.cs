using System.ComponentModel.DataAnnotations;

namespace ORM
{
    public class RequestMerchandise
    {
        [Key]
        public int Id { get; set; }

        public int MerchandiseId { get; set; }

        public int Amount { get; set; }

        public int UserId { get; set; }

        public int RequestId { get; set; }
    }
}