using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductShop.Models;
using ProductShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ProductShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _ProductRepository;

        public HomeController(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductOnSale = _ProductRepository.GetProductOnSale
            };

            return View(homeViewModel);
        }
    }
}