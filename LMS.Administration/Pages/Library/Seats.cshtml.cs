using LMS.Administration.Middleware;
using LMS.Administration.Pages.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Library
{
    public class SeatsModel : PageModel
    {
        private readonly ILogger<SeatsModel> _logger;
        private readonly IStudentSeatBookingService _studentSeatBookingService;
        private readonly IActiveUserService _activeUserService;
        public SeatsModel(ILogger<SeatsModel> logger, IStudentSeatBookingService studentSeatBookingService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _studentSeatBookingService = studentSeatBookingService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.StudentSeatBooking> studentSeatBookings { get; set; }
        [BindProperty]
        public StudentSeatBooking newStudentSeatBooking { get; set; }
        [BindProperty]
        public StudentSeatBooking editStudentSeatBooking { get; set; }
        public async Task<IActionResult> OnGet()
        {
            studentSeatBookings = await _studentSeatBookingService.GetStudentSeatBookings();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                studentSeatBookings = await _studentSeatBookingService.GetStudentSeatBookings();
                return Page();
            }

            if (string.IsNullOrEmpty(newStudentSeatBooking.StudentSeatBookingId))
            {
                LMS.Mapper.BusinessObject.StudentSeatBooking studentSeatBooking = new Mapper.BusinessObject.StudentSeatBooking();
                studentSeatBooking.StudentId = newStudentSeatBooking.StudentId;
                studentSeatBooking.SeatNo = newStudentSeatBooking.SeatNo;
                studentSeatBooking.TokenNo = newStudentSeatBooking.TokenNo;
                studentSeatBooking.FromDate = newStudentSeatBooking.FromDate;
                studentSeatBooking.ToDate = newStudentSeatBooking.ToDate;
                studentSeatBooking.IsActive = newStudentSeatBooking.IsActive;
                studentSeatBooking.CreatedOn = DateTime.Now;
                studentSeatBooking.CreatedBy = _activeUserService.UserId;
                int isSave = await _studentSeatBookingService.InsertStudentSeatBooking(studentSeatBooking);
            }
            else
            {
                var existingModel = await _studentSeatBookingService.GetStudentSeatBookingById(newStudentSeatBooking.StudentSeatBookingId);
                if (existingModel != null)
                {
                    existingModel.StudentId = newStudentType.StudentId;
                    existingModel.SeatNo = newStudentType.SeatNo;
                    existingModel.TokenNo = newStudentType.TokenNo;
                    existingModel.FromDate = newStudentType.FromDate;
                    existingModel.ToDate = newStudentType.ToDate;
                    existingModel.IsActive = newStudentType.IsActive;
                    existingModel.ModifiedOn = DateTime.Now;
                    existingModel.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _studentSeatBookingService.UpdateStudentSeatBooking(existingModel);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingModel = await _studentSeatBookingService.GetStudentSubTypeById(id);
            if (existingModel == null)
            {
                return NotFound();
            }

            editStudentType.StudentId = existingModel.StudentId;
            editStudentType.SeatNo = existingModel.SeatNo;
            editStudentType.TokenNo = existingModel.TokenNo;
            editStudentType.FromDate = existingModel.FromDate;
            editStudentType.ToDate = existingModel.ToDate;
            editStudentType.IsActive = existingModel.IsActive;

            studentSeatBookings = await _studentSeatBookingService.GetStudentSeatBookings();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _studentSeatBookingService.DeleteStudentSeatBooking(id);

            studentSeatBookings = await _studentSeatBookingService.GetStudentSeatBookings();
            return Page();
        }
    }
    public class StudentSeatBooking
    {
        public string StudentSeatBookingId { get; set; }
        [Required]
        [DisplayName("Student")]
        public string StudentId { get; set; } = null!;
        public List<SelectListItem> lstStudents { get; set; } = null!;
        [Required]
        [DisplayName("Seat No")]
        public int SeatNo { get; set; } = 0!;
        [Required]
        [DisplayName("Token No")]
        public string TokenNo { get; set; } = null!;
        [Required]
        [DisplayName("From")]
        public Datetime FromDate { get; set; } = null!;
        [Required]
        [DisplayName("To")]
        public Datetime ToDate { get; set; } = null!;
        [DisplayName("Status")]
        public bool IsActive { get; set; }
    }
}
