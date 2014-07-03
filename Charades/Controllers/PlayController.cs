using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Charades.Business.Interface;

namespace Charades.Controllers
{
    public class PlayController : Controller
    {
        private readonly IPhraseModule _phraseModule;

        public PlayController(IPhraseModule phraseModule)
	    {
            _phraseModule = phraseModule;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetRandomPhrase()
        {
            return Json ( _phraseModule.GetRandomPhrase() );
        }
    }
}