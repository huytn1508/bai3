using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using bai3.Models;

namespace bai3.Controllers
{
    public class categoryController : Controller
    {
        //gia lap csdl
        public static List<Models.Category> categories = new List<Models.Category>
        {
            new Models.Category { Id = 1, Name = "Laptop" },
            new Models.Category { Id = 2, Name = "Phone" },
            new Models.Category { Id = 3, Name = "Tablet" }
        };
        // GET: categoryController
        [HttpGet]
        public ActionResult Index()
        {

            return View(categories);
        }

        // GET: categoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: categoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
     
            {
                category.Id = categories.Count + 1;
                categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
           
        }

        // GET: categoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: categoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            var existingCategory = categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory != null)
            {
                return NotFound();
            }
           existingCategory?.Name = category.Name;
            return RedirectToAction(nameof(Index));
        }

        // GET: categoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if(category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: categoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            categories.Remove(category);
            return RedirectToAction(nameof(Index));

        }
    }
}
