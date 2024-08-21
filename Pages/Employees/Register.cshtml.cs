using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Pages.Employees
{
    public class RegisterModel : PageModel
    {
        public readonly AppDbContext context;
        public RegisterModel (AppDbContext context)
        {
            this.context= context;
        }
        [BindProperty]
        public Employee Employee { get; set; }
        public SkillAssesment Skill {  get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Skill = new SkillAssesment { Id = Employee.EmpId };
            context.SkillAssessments.Add(Skill);
            context.SaveChanges();
            var skillAssessment = context.SkillAssessments.Find(Employee.EmpId);
            if (skillAssessment == null)
            {
                ModelState.AddModelError(string.Empty, "SkillAssessment with the specified Id does not exist.");
                return Page();
            }

            context.Employees.Add(Employee);
            context.SaveChanges();
            TempData["Message"] = "Added Employee";
            return RedirectToPage("./SkillAssesment",new {id =Employee.EmpId });
        }
    }
}
