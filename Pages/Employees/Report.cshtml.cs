using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages.Employees
{
    public class ReportModel : PageModel
    {
        public readonly AppDbContext context;

        [BindProperty]
        public List<string> SelectedSkills { get; set; }

        public List<Employee> EmployeeDetails { get; set; }

        public ReportModel(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnPost()
        {
            if (SelectedSkills != null && SelectedSkills.Any())
            {
                // Query the database to retrieve employees with skill ratings greater than 3 for selected skills
                EmployeeDetails = context.Employees
                    .Where(e =>
                        context.SkillAssessments
                            .Any(sa =>
                                sa.Id == e.EmpId &&
                                (
                                    (SelectedSkills.Contains("BasicUnderstanding") && sa.BasicUnderstanding > 3) ||
                                    (SelectedSkills.Contains("WorkingExperience") && sa.WorkingExperience > 3) ||
                                    (SelectedSkills.Contains("ExtensiveExperience") && sa.ExtensiveExperience > 3) ||
                                    (SelectedSkills.Contains("SubjectMatterExperience") && sa.SubjectMatterExperience > 3) ||
                                    (SelectedSkills.Contains("Database") && sa.Database > 3) ||
                                    (SelectedSkills.Contains("Programming") && sa.Programming > 3) ||
                                    (SelectedSkills.Contains("Java") && sa.Java > 3) ||
                                    (SelectedSkills.Contains("CSharp") && sa.CSharp > 3) ||
                                    (SelectedSkills.Contains("Python") && sa.Python > 3) ||
                                    (SelectedSkills.Contains("WebProgramming") && sa.WebProgramming > 3) ||
                                    (SelectedSkills.Contains("OtherTechnicalSkills") && sa.OtherTechnicalSkills > 3) ||
                                    (SelectedSkills.Contains("VerbalCommunication") && sa.VerbalCommunication > 3) ||
                                    (SelectedSkills.Contains("WrittenCommunication") && sa.WrittenCommunication > 3) ||
                                    (SelectedSkills.Contains("ForeignLanguage") && sa.ForeignLanguage > 3) ||
                                    (SelectedSkills.Contains("Teamwork") && sa.Teamwork > 3) ||
                                    (SelectedSkills.Contains("ProblemSolving") && sa.ProblemSolving > 3) ||
                                    (SelectedSkills.Contains("DecisionMaking") && sa.DecisionMaking > 3) ||
                                    (SelectedSkills.Contains("Leadership") && sa.Leadership > 3) 
                                )
                            )
                    )
                    .ToList();
                
            }
            
            return Page();
        }
    }
}
