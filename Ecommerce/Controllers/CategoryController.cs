using AutoMapper;
using Domino;
using Ecommerce.Models;
using InfreaStructure.ImplementationServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Services.ServicesContractor;

namespace Ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        IServicesBase<Category>   servicesBase { get; set; }
        
        IMapper mapper;

        public CategoryController(IServicesBase<Category> servicesBase, IMapper mapper)
        {
            this.servicesBase = servicesBase;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(this.servicesBase.GetAll().Select(role => mapper.Map<Category, CategoryDTO>(role)).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryDTO categoryDTO)
        {
            var categoryresult = mapper.Map<Category>(categoryDTO);

            this.servicesBase.Add(categoryresult);
            return RedirectToAction("index");
        }

        public IActionResult Details(int id)
        {

            var categoryresult = mapper.Map<CategoryDTO>(this.servicesBase.GetById(id));
            
            return View(categoryresult);
        }

        public IActionResult Delete(int id)
        {

            var categoryresult = mapper.Map<CategoryDTO>(this.servicesBase.GetById(id));

            return View(categoryresult);
        }

        [HttpPost]
        public IActionResult Delete(int id,CategoryDTO categoryDTO)
        {  
            this.servicesBase.Delete(id);
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {

            var categoryresult = mapper.Map<CategoryDTO>(this.servicesBase.GetById(id));

            return View(categoryresult);
        }


        [HttpPost]
        public IActionResult Edit(int id, CategoryDTO categoryDTO)
        {
            var categoryresult = mapper.Map<Category>(categoryDTO);
            this.servicesBase.Update(categoryresult);

            return RedirectToAction("index");
        }





    }
}
