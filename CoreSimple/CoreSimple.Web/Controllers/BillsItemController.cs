using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSimple.Models;
using CoreSimple.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreSimple.Web.Controllers
{
    public class BillsItemController : Controller
    {
        public BillsItemController(IBillsItemService billsItemService)
        {
            BillsItemService = billsItemService;
        }

        public IBillsItemService BillsItemService { get; }

        public IActionResult Index()
        {
            BillsItem item = new BillsItem
            {
                CreationTime = DateTime.Now,
                Market = "南城",
                ProductNoName = "302上衣",
                ProductNumber = 30,
                Shop = "1-1-11"
            };
           BillsItemService.AddAsync(item);
            return Content("add ..");
        }
    }
}