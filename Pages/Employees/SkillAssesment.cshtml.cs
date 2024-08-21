using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Pages.Employees
{
    public class SkillAssesmentModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public readonly AppDbContext context;
        public SkillAssesmentModel(AppDbContext context)
        {
            this.context=context;
        }
        [BindProperty]
        public SkillAssesment Skill{  get; set; }
        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var skill = context.SkillAssessments.FirstOrDefault(m => m.Id==id);
            if(skill == null)
            {
                return NotFound();
            }
            Skill = skill;
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            context.Attach(Skill).State = EntityState.Modified;

            context.SaveChanges();
            TempData["Message"] = "Data Saved";
            return RedirectToPage("./approval", new { id = Skill.Id });
        }
    }
}
