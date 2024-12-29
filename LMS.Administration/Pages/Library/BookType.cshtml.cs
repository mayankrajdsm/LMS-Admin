using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Library
{
    public class BookTypeModel : PageModel
    {
        [BindProperty]
        public BookType addBookType { get; set; }
        [BindProperty]
        public BookType editBookType { get; set; }

        public void OnGet()
        {
        }
    }
    public class BookType
    {
        public string id { get; set; }

        [Required]
        [DisplayName("Code")]
        public string code { get; set; }

        [Required]
        [DisplayName("Name")]
        public string name { get; set; }

        [Required]
        [DisplayName("Status")]
        public bool IsActive { get; set; }
    }
}
