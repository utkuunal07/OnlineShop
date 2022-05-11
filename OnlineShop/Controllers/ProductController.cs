using ProductShop.Models;
using ProductShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _ProductRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository ProductRepository, ICategoryRepository categoryRepository)
        {
            _ProductRepository = ProductRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Product> Products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                Products = _ProductRepository.GetAllProduct.OrderBy(c => c.ProductId);
                currentCategory = "All Product";
            }
            else
            {
                Products = _ProductRepository.GetAllProduct.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = Products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var Product = _ProductRepository.GetProductById(id);
            if (Product == null)
                return NotFound();

            return View(Product);
        }
    }
}
