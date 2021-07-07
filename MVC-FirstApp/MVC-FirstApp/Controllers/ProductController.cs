using System.Web.Mvc;
using MVC_FirstApp.Domain.Abstract;

namespace MVC_FirstApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly iProductRepository repository;
        public ProductController(iProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult ProductList()
        {
            return View(repository.Products);
        }
    }
}