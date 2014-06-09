using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Charades.Business.Interface;

namespace Charades.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhraseModule _phraseModule;

        public HomeController(IPhraseModule phraseModule)
	    {
            _phraseModule = phraseModule;
        }

        // GET: Home
        public ActionResult Index()
        {
            _phraseModule.GetRandomPhrase();
            return View();
        }
    }
}