using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edure.Web.UI.Repostory.Abstrac;
using Edure.Web.UI.Repostory.Abstrac.UniteOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Edure.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepstory repstory;
        private readonly IUniteOfWork uniteOfWork;
        public HomeController(IProductRepstory _repstory, IUniteOfWork uniteOfWork)
        {
            repstory = _repstory;
            this.uniteOfWork = uniteOfWork;

        }
        public IActionResult Index()
        {
            return View(uniteOfWork.product.GetAll());
        }
    }
}