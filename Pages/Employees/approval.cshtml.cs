using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Pages.Employees
{
    public class approvalModel : PageModel
    {
      
        public readonly AppDbContext context;
        public approvalModel(AppDbContext context)
        {
            this.context = context;
        }
        [BindProperty]
        public string approval {  get; set; }
        public IActionResult OnPost(string id)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            if(approval == "accept")
            {
                TempData["Message"] = "Data Saved";
                return RedirectToPage("./Index");
            }
            else
            {
                var employee=context.Employees.FirstOrDefault(m => m.EmpId == id);
                if(employee == null)
                {
                    return NotFound();
                }
                context.Employees.Remove(employee);
                context.SaveChanges();
                var skill=context.SkillAssessments.FirstOrDefault(m => m.Id== id);
                if(skill== null)
                {
                    return NotFound();
                }
                context.SkillAssessments.Remove(skill);
                context.SaveChanges();
            }
            TempData["Message"] = "Data Rejected";
            return RedirectToPage("./Index");
        }
    }
}
