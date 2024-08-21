using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages.Employees
{
    public class SkillAssesmentDetailsModel : PageModel
    {
        public AppDbContext context { get; set; }
        [BindProperty]
        public SkillAssesment SkillAssesment { get; set; }
        public SkillAssesmentDetailsModel(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet(string id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var skill=context.SkillAssessments.FirstOrDefault(x => x.Id==id);
            if(skill==null)
            {
                return NotFound();
            }
            SkillAssesment = skill;
            return Page();
        }
    }
}
