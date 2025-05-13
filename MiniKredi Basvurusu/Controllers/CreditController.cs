using Microsoft.AspNetCore.Mvc;
using MiniKredi_Basvurusu.Services;
using MiniKredi_Basvurusu.Services.Interfaces;
using MiniKredi_Basvurusu.ViewModels;

namespace MiniKredi_Basvurusu.Controllers
{
    public class CreditController : Controller
    {
        private readonly IApplicationService _applicationService;

        public CreditController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CreditApplicationViewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            string resultMessage = _applicationService.Evaluate(model);
            ViewBag.Message = resultMessage;

            return View(model);
        }


    }
}
