using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public Category Category { get; set; }
        public void OnGet(int Id)
        {
            var categoryFromDb = _db.Categories.Find(Id);

            if (categoryFromDb != null)
            {
                Category = _db.Categories.FirstOrDefault(c => c.Id == categoryFromDb.Id);
            }
        }

        public IActionResult OnPost()
        {

            var categoryFromDb = _db.Categories.Find(Category.Id);
            if (categoryFromDb != null)
            {
                _db.Categories.Remove(categoryFromDb);
                _db.SaveChanges();
                TempData["success"] = "Category deleted successfully!";
                return RedirectToPage("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
