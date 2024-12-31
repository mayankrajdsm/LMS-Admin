using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Staff
{
    public class StaffQualificationModel : PageModel
    {
        public StaffQE staffQE { get; set; }
        public void OnGet()
        {
        }
    }
    public class StaffQE
    {
        public StaffQalification staffQalification { get; set; }
        public StaffExperience staffExperience { get; set; }
    }
    public class StaffQalification
    {
        public string StaffId { get; set; }
        public string Qualification { get; set; }
        public string Subject { get; set; }
        public string Board { get; set; }
        public int PassingYear { get; set; }
        public int Percentage { get; set; }
    }
    public class StaffExperience
    {
        public string StaffId { get; set; }
        public string Organization { get; set; }
        public string Designation { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
