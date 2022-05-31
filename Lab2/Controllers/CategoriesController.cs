using Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {

        static List<CategoriesModel> categoryList = new List<CategoriesModel>
        {

            new CategoriesModel {Id = 1, Category = "Food"},
            new CategoriesModel {Id = 2, Category = "Tech"},
            new CategoriesModel {Id = 3, Category = "Sports"},

        };
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(categoryList);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {

            var categorySelected = categoryList.First<CategoriesModel>(x => x.Id == id);
            ViewBag.Message = "The Category you Selected is: " + categorySelected.Category;
            return View(categorySelected);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController/Edit/5
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

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController/Delete/5
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
