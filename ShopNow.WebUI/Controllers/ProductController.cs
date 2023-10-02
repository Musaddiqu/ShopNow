using ShopNow.Model;
using ShopNow.Repository.Common.Repository.Impl;
using ShopNow.Repository.Common.Repository.Inerface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopNow.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        private ICategoryRepositery categoryRepositery;
        public ProductController(IProductRepository productRepository, ICategoryRepositery categoryRepositery)
        {
            this.productRepository = productRepository;
            this.categoryRepositery = categoryRepositery;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(productRepository.GetAll());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(productRepository.Get(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product model)
        {
            try
            {
                // TODO: Add insert logic here
                productRepository.Insert(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
           var productModel= productRepository.Get(id);
            return View(productModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product newModel)
        {
            try
            {
                // TODO: Add update logic here
               
                productRepository.Update(newModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(productRepository.Get(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                productRepository.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
