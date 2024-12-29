using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMS.Administration.Pages.Subscription
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ISubscriptionsTransactionService _subscriptionsTransactionService;
        private readonly ISubscriptionPaymentService _paymentService;
        private readonly ISubscriptionPackageService _packageService;
        private readonly IActiveUserService _activeUserService;
        public IndexModel(ILogger<IndexModel> logger, ISubscriptionsTransactionService subscriptionsTransactionService, IActiveUserService activeUserService, ISubscriptionPaymentService paymentService, ISubscriptionPackageService packageService)
        {
            _logger = logger;
            _subscriptionsTransactionService = subscriptionsTransactionService;
            _activeUserService = activeUserService;
            _paymentService = paymentService;
            _packageService = packageService;
        }
        public List<LMS.Mapper.BusinessObject.SubscriptionsTransaction> subscriptionsTransactions { get; set; }
        [BindProperty]
        public SubscriptionsTransaction addSubscriptionsTransaction { get; set; }
        public LMS.Mapper.BusinessObject.SubscriptionsTransaction subscriptionsTransaction { get; set; }
        public async Task<IActionResult> OnGet()
        {
            subscriptionsTransactions = await _subscriptionsTransactionService.GetSubscriptionsTransactions();
            addSubscriptionsTransaction.lstStudentTeacher = new List<SelectListItem>
            {
              new SelectListItem { Value = "S", Text = "Student" },
              new SelectListItem { Value = "T", Text = "Teacher" },
            };
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                subscriptionsTransactions = await _subscriptionsTransactionService.GetSubscriptionsTransactions();
                return Page();
            }

            if (string.IsNullOrEmpty(addSubscriptionsTransaction.SubscriptionsTransactionStudentId))
            {
                LMS.Mapper.BusinessObject.SubscriptionsTransaction model = new Mapper.BusinessObject.SubscriptionsTransaction();
                model.StudentTeacher = addSubscriptionsTransaction.StudentTeacher;
                model.StudentTeacherId = addSubscriptionsTransaction.StudentTeacher == "Student" ? addSubscriptionsTransaction.StudentId : addSubscriptionsTransaction.TeacherId;
                model.SubscriptionPakageId = addSubscriptionsTransaction.SubscriptionPackageId;
                model.ValidFrom = addSubscriptionsTransaction.ValidFrom;
                model.ValidTo = addSubscriptionsTransaction.ValidTo;
                model.IsActive = addSubscriptionsTransaction.IsActive;
                model.CreatedOn = DateTime.Now;
                model.CreatedBy = _activeUserService.UserId;
                int isSave = await _subscriptionsTransactionService.InsertSubscriptionsTransaction(model);
                if (isSave > 0)
                {
                    LMS.Mapper.BusinessObject.SubscriptionPayment paymentModel = new Mapper.BusinessObject.SubscriptionPayment();

                    var package = await _packageService.GetSubscriptionPackageById(addSubscriptionsTransaction.SubscriptionPackageId);

                    paymentModel.StudentTeacher = model.StudentTeacher;
                    paymentModel.ReceiptNo = "";
                    paymentModel.StudentTeacherId = addSubscriptionsTransaction.StudentTeacher == "Student" ? addSubscriptionsTransaction.StudentId : addSubscriptionsTransaction.TeacherId;
                    paymentModel.SubscriptionPakageId = addSubscriptionsTransaction.SubscriptionPackageId;
                    paymentModel.Rate = package.PriceMonth;
                    paymentModel.Months = package.SubscriptionPeriodMonths;
                    paymentModel.DiscountPer = package.DiscountPer;

                    int isPayment = await _paymentService.InsertSubscriptionPayment(paymentModel);
                    if (isPayment > 0)
                    {

                    }
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            subscriptionsTransaction = await _subscriptionsTransactionService.GetSubscriptionsTransactionById(id);
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            var transaction = await _subscriptionsTransactionService.GetSubscriptionsTransactionById(id);
            if (transaction != null)
            {
                transaction.IsActive = false;
                int isTransactionUpdate = await _subscriptionsTransactionService.UpdateSubscriptionsTransaction(transaction);
                if (isTransactionUpdate > 0)
                {
                    var payment = await _paymentService.GetSubscriptionPaymentById(transaction.PaymentId);
                    if (payment != null)
                    {
                        payment.IsActive = false;
                        int isPaymentUpdate = await _paymentService.UpdateSubscriptionPayment(payment);
                        if (isPaymentUpdate > 0)
                        {
                        }
                    }
                }
            }

            //subscriptionsTransactions = await _subscriptionsTransactionService.GetSubscriptionsTransactions();
            return Page();
        }
    }
    public class SubscriptionsTransaction
    {
        public string SubscriptionsTransactionStudentId { get; set; }

        [Required(ErrorMessage = "Student/Teacher Required.")]
        [DisplayName("Student/Teacher")]
        public string StudentTeacher { get; set; } = null!;
        public List<SelectListItem> lstStudentTeacher { get; set; }

        [Required(ErrorMessage = "Student Required.")]
        [DisplayName("Student")]
        public string StudentId { get; set; }
        public List<SelectListItem> lstStudents { get; set; }

        [Required(ErrorMessage = "Teacher Required.")]
        [DisplayName("Teacher")]
        public string TeacherId { get; set; }
        public List<SelectListItem> lstTeachers { get; set; }

        [Required(ErrorMessage = "Subscription Package Required.")]
        [DisplayName("Subscription Pakage")]
        public string SubscriptionPackageId { get; set; }
        public List<SelectListItem> lstSubscriptionPackage { get; set; }

        [Required(ErrorMessage = "Valid From Required.")]
        [DisplayName("Valid From")]
        public DateTime ValidFrom { get; set; }

        [Required(ErrorMessage = "Valid To Required.")]
        [DisplayName("Valid To")]
        public DateTime ValidTo { get; set; }

        [Required(ErrorMessage = "Status Required.")]
        [DisplayName("Status")]
        public bool IsActive { get; set; } = true;
    }
}
