using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderProcessWeb.ViewModels
{
    public class MerchandiseViewModel
    {
        public int Id { get; set; }

        public int Amount { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}