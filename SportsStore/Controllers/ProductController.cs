using System;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller{
        private IProductRepository repo;

        public ProductController(IProductRepository r){
            repo = r;
        }

        public ViewResult List() => View(repo.Products);
    }
}
