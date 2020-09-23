using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bethanypieshop.Models;
using Bethanypieshop.ViewModels;
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

            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "cheese cake";
            return View(piesListViewModel);
        }
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
