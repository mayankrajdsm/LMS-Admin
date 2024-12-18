using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using LMS.Mapper.Services;

namespace LMS.Admin.Views.Home
{
    public class ContactUsModel : PageModel
    {
        private readonly ILogger<ContactUsModel> _logger;
        private readonly IContactUsService _contactUsService;
        private readonly IActiveUserService _activeUserService;
        public ContactUsModel(ILogger<ContactUsModel> logger,
            IContactUsService contactUsService,
            IActiveUserService activeUserService)
        {
            _logger = logger;
            _contactUsService = contactUsService;
            _activeUserService = activeUserService;
        }
        public ContactUs contactUs { get; set; }
        public async Task<IActionResult> OnGet()
        {
            var existingContact = _contactUsService.GetContactUs().Result.FirstOrDefault();
            contactUs.id = existingContact.ContactUsId;
            contactUs.heading = "";
            contactUs.message = existingContact.ContactUsText;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(contactUs.id))
                {
                    LMS.Mapper.BusinessObject.ContactU contact = new Mapper.BusinessObject.ContactU();
                    contact.ContactUsText = contactUs.message;
                    contact.CreatedOn = DateTime.Now;
                    contact.CreatedBy = _activeUserService.UserId;

                    int isSave = await _contactUsService.InsertContactUs(contact);
                }
                else
                {
                    var existingContact = await _contactUsService.GetContactUsById(contactUs.id);
                    if (existingContact != null)
                    {
                        existingContact.ContactUsText = contactUs.message;
                        existingContact.ModifiedBy = _activeUserService.UserId;
                        existingContact.ModifiedOn = DateTime.Now;

                        int isSave = await _contactUsService.UpdateContactUs(existingContact);

                        if (isSave > 0)
                        {

                        }
                    }
                }
            }
            return Page();
        }
    }
    public class ContactUs
    {
        public string id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string heading { get; set; }
        [Required]
        [DisplayName("Content")]
        public string message { get; set; }
    }
}

