using AutoMapper;
using Domino;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Services.ServicesContractor;
using System.Data;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        IMapper mapper;

        IServicesProduct ServicesProduct { get; set; }

        public ProductController(IMapper mapper, IServicesProduct _servicesProduct)
        {
            this.mapper = mapper;

            ServicesProduct = _servicesProduct;
          
        }

        public IActionResult Index()
        {
            return View(ServicesProduct.GetAllProducts().Select(role => mapper.Map<Product, ProductDTO>(role)).ToList());


          /*  return View(ServicesProduct.GetAllProducts().Select(a=> new ProductDTO{
             Code = a.Code,
             Description = a.Description,
             Id = a.Id,
             Nombre = a.Name,
             Price = a.Price,
             Quantity = a.Quantity
            
            }));  */


        }

        public IActionResult SaveProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveProduct(ProductDTIN productin)
        {
            var productresult = mapper.Map<Product>(productin);

            ServicesProduct.AddProduct(productresult);


            return View();
        }

        public IActionResult Edit(int Id)
        {
            var prod =   ServicesProduct.GetProductById(Id);

            var productresult = mapper.Map<ProductDTIN>(prod);
            return View(productresult);
        }

        [HttpPost]
        public IActionResult Edit(int Id, ProductDTIN productDTIN)
        { 
            var productresult = mapper.Map<Product>(productDTIN);
            productresult.Id = Id;
            ServicesProduct.UpdateProduct(productresult);   
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            var prod = ServicesProduct.GetProductById(Id);

            var productresult = mapper.Map<ProductDTO>(prod);
            return View(productresult);
        }


        public IActionResult Delete (int Id)
        {
            var prod = ServicesProduct.GetProductById(Id);

            var productresult = mapper.Map<ProductDTO>(prod);
            return View(productresult);

        }

        [HttpPost]
        public IActionResult Delete(int Id, ProductDTO productDTO)
        {
            var prod = ServicesProduct.DeleteProduct(Id);

      
            return RedirectToAction("Index");

        }




    }
}
