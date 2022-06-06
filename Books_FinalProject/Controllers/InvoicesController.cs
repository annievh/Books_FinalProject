using Books_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Books_FinalProject.Controllers
{
    public class InvoicesController : Controller
    {
        // GET: Invoices
        public ActionResult All()
        {
            BooksEntities context = new BooksEntities();
            return View();
        }
    }
}