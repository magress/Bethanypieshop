using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bethanypieshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bethanypieshop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepostory)
        {
            _categoryRepository = categoryRepostory;
            _pieRepository = pieRepository;

        }

        public ViewResult List() 
        {
            
            ViewBag.CurrentCategory = "Cheese cakes";

            return View(_pieRepository.AllPies);
        }
    }
}
