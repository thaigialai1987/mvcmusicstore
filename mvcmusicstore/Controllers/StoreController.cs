using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcmusicstore.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store
        public string Index()
        {
            return "Hello from store.index";
        }

        // GET: /Store/Browse
        public string Browse()
        {
            return "Hello from browse";
        }

        // GET: /Store/Details
        public string Details()
        {
            return "Hello from store.details";
        }
    }
}