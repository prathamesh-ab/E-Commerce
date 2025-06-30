using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;  
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public Category? Category { get; set; }


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
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category Updated successfully!";
                return RedirectToPage("Index");
            }
            return Page(); // If the model state is not valid, return the same page to show validation errors.
        }
    }
}
