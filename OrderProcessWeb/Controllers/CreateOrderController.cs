using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL.Interfaces;
using OrderProcessWeb.Infrastructure.Mappers;
using OrderProcessWeb.ViewModels;
using WebGrease.Css.Extensions;

namespace OrderProcessWeb.Controllers
{
    public class CreateOrderController : Controller
    {
        private readonly IRequestService requestService;
        private readonly IRequestMerchandiseService requestMerchandiseService;
        private readonly IMerchandiseService merchandiseService;

        public CreateOrderController(IRequestService requestService, IRequestMerchandiseService requestMerchandiseService,
            IMerchandiseService merchandiseService)
        {
            this.requestService = requestService;
            this.requestMerchandiseService = requestMerchandiseService;
            this.merchandiseService = merchandiseService;
        }

        [HttpGet]
        public ActionResult CreateOrder()
        {
            var model = new RequestListViewModel();
            var listModel = requestService.GetAllRequests();
            var list = listModel.Select(elem => new SelectListItem()
            {
                Value = elem.Id.ToString(),
                Text = "Request#" + elem.Id.ToString()
            }).ToList();

            model.Requests = list;
            return View(model);
        }

        [HandleError(ExceptionType = typeof(NullReferenceException))]
        public ActionResult GetRequest(string selectedRequestId)
        {
            int requestId = int.Parse(selectedRequestId);
            var request = requestService.GetRequest(requestId);
            var requestMerchndiseList = requestMerchandiseService.GetAllRequestMerchandises(requestId);
            var requestMerchandiseModel = requestMerchndiseList.Select(x => new RequestMerchandiseViewModel()
            {
                Id = x.Id,
                Amount = x.Amount,
                RequestId = x.RequestId,
                UserId = x.UserId,
                Merchandise = merchandiseService.GetMerchandise(x.MerchandiseId).ToMerchandiseViewModel()
            }).ToList();

            var model = new RequestViewModel()
            {
                Id = requestId,
                RequestMerchandises = requestMerchandiseModel,
                AdditionalInfo = request.AdditionalInfo
            };

            return PartialView("RequestInfoPartial", model);
        }
    }
}