using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Data.Entities.DB;
using Microsoft.AspNetCore.Mvc;

namespace SaasBerry_DemoApplication.Controllers
{
    public class AccountsController : Controller
    {
        private dbsbltest1Entities dbContext;
        public AccountsController(dbsbltest1Entities _dbContext)
        {
            dbContext = _dbContext;
        }

        
        public IActionResult AccountList()
        {
            var totalRec = 0;
            //var AccountList = dbContext.Account.Where(x=>x.AccountId == 107976).Skip(0).Take(2).OrderByDescending(x=>x.AccountId).ToList();

           var AccountList = dbContext.GetProductByIDAsync(1, 10);
            ViewBag.Alist = AccountList;
            ViewBag.AccountListCount = totalRec;
            return View();
        }
    }
    //    public ActionResult AccountLoadMore(int? accountCount)
    //    {
    //                    var totalRec = 0;
           
               
    //            //var SearchClientListFinal = objClient.GetAccountListing();
    //            //ViewBag.ClientListCount = totalRec;
               
           
    //            //    return Json(lst, JsonRequestBehavior.AllowGet);
               
    //}
}