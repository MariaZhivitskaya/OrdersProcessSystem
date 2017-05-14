using System.ComponentModel.DataAnnotations;

namespace ORM
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
       
        public string AdditionalInfo { get; set; }
    }
}