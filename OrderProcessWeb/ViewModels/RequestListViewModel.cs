using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderProcessWeb.ViewModels
{
    public class RequestListViewModel
    {
        public int SelectedRequestNumber { get; set; }

        public List<SelectListItem> Requests { get; set; }
    }
}