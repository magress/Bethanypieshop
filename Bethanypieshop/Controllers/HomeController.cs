using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bethanypieshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bethanypieshop.Controllers
{


    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new ViewModels.HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }


    }
}

