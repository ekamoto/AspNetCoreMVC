using System.Linq;
using AspNetCoreMVC.Data;
using AspNetCoreMVC.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC
{
    public class CategoryController: Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;    
        }

        public IActionResult Index(int id)
        {

            var categorias = _context.Categories.ToList();
            ViewBag.ListaCategorias = categorias;

            var categorySelected = _context.Categories.Find(id);

            return View(categorySelected);
        }

        [HttpPost]
        public IActionResult Register(Category category)
        {
            if(category.Id==0)
            {
                _context.Categories.Add(category);
            } 
            else
            {
                
                var categorySave = _context.Categories.Find(category.Id);
                categorySave.Name = category.Name;

                _context.Categories.Update(categorySave);
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete (int id)
        {
            var categorySelected = _context.Categories.Find(id);
            _context.Categories.Remove(categorySelected);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}