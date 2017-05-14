using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderProcessWeb.ViewModels
{
    public class RequestViewModel
    {
        public int Id { get; set; }

        public List<RequestMerchandiseViewModel> RequestMerchandises { get; set; }

        public string AdditionalInfo { get; set; }
    }
}