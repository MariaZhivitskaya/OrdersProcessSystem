using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderProcessWeb.ViewModels
{
    public class RequestMerchandiseViewModel
    {
        public int Id { get; set; }

        public MerchandiseViewModel Merchandise { get; set; }

        public int Amount { get; set; }

        public int UserId { get; set; }

        public int RequestId { get; set; }
    }
}