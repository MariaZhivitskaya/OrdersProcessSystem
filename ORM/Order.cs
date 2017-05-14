using System;
using System.ComponentModel.DataAnnotations;

namespace ORM
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int MerchandiseId { get; set; }

        public int Amount { get; set; }

        public int TotalPrice { get; set; }

        public int UserId { get; set; }

        public string AdditionalInfo { get; set; }
    }
}