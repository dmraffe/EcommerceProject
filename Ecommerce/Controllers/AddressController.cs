using AutoMapper;
using Domino;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.ServicesContractor;

namespace Ecommerce.Controllers
{
    public class AddressController : Controller
    {
        IServicesBase<CustomerAddres> servicesBase { get; set; }

        IMapper mapper;

        public AddressController(IServicesBase<CustomerAddres> servicesBase, IMapper mapper)
        {
            this.servicesBase = servicesBase;
            this.mapper = mapper;
        }

        // GET: AddressController


        public ActionResult Index()
        {

            return View(this.servicesBase.GetAll().Select(role => mapper.Map<CustomerAddres, AddressDTO>(role)).ToList());
        }

        // GET: AddressController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddressController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressController/Create
        [HttpPost]
       
        public ActionResult Create(AddressDTI collection)
        {
            var Isok = ModelState.IsValid;
           
            

            if (!Isok)
            {
                var message = string.Join(" | ", ModelState.Values
                .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));
                ViewBag.Error = message;
                return View();
            }

            try                        
            {   
                    this.servicesBase.Add(mapper.Map<CustomerAddres>(collection));
                    return RedirectToAction(nameof(Index));

               
               
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]

        public ActionResult CreateService(AddressDTI collection)
        {
            var Isok = ModelState.IsValid;

            string error = string.Empty;
            if (string.IsNullOrEmpty(collection.State))
                error += "Ingresar el estado";

            if (!Isok)
            {
                var message = string.Join(" | ", ModelState.Values
                .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));
                ViewBag.Error = message;
                return BadRequest(message);
            }

            try
            {
                
                return Json(this.servicesBase.Add(mapper.Map<CustomerAddres>(collection)));



            }
            catch
            {
                return NotFound();
            }
        }

        // GET: AddressController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddressController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddressController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
