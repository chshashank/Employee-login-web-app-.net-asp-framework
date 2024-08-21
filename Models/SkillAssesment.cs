using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class SkillAssesment
    {
        
        [MaxLength(5)]
        public required string Id { get; set; }
        public int BasicUnderstanding { get; set; } 
        public int WorkingExperience { get; set; }
        public int ExtensiveExperience { get; set; }
        public int SubjectMatterExperience { get; set; }
        public int Database { get; set; }
        public int Programming { get; set; }
        public int Java { get; set; }
        public int CSharp { get; set; }
        public int Python { get; set; }
        public int WebProgramming { get; set; }
        public int OtherTechnicalSkills { get; set; }
        public int VerbalCommunication { get; set; }
        public int WrittenCommunication { get; set; }
        public int ForeignLanguage { get; set; }
        public int Teamwork { get; set; }
        public int ProblemSolving { get; set; }
        public int DecisionMaking { get; set; }
        public int Leadership { get; set; }
    }
}
