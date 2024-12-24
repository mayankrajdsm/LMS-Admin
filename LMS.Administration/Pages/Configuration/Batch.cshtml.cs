using LMS.Administration.Middleware;
using LMS.Administration.Pages.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Configuration
{
    public class BatchModel : PageModel
    {
        private readonly ILogger<BatchModel> _logger;
        private readonly IBatchService _batchService;
        private readonly IActiveUserService _activeUserService;
        public BatchModel(IBatchService batchService, ILogger<BatchModel> logger, IActiveUserService activeUserService)
        {
            _batchService = batchService;
            _logger = logger;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.Batch> batches { get; set; }
        public Batch newBatch { get; set; }
        public Batch editBatch { get; set; }
        public async Task<IActionResult> OnGet()
        {
            batches = await _batchService.GetBatches();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                batches = await _batchService.GetBatches();
                return Page();
            }

            if (string.IsNullOrEmpty(newBatch.BatchId))
            {
                LMS.Mapper.BusinessObject.Batch batch = new Mapper.BusinessObject.Batch();
                batch.BatchCode = newBatch.BatchCode;
                batch.FromDate = newBatch.FromDate;
                batch.ToDate = newBatch.ToDate;
                batch.IsActive = true;
                batch.CreatedOn = DateTime.Now;
                batch.CreatedBy = _activeUserService.UserId;
                int isSave = await _batchService.InsertBatch(batch);
            }
            else
            {
                var existingBatch = await _batchService.GetBatchById(newBatch.BatchId);
                if (existingBatch != null)
                {
                    existingBatch.BatchCode = newBuilding.BatchCode;
                    existingBatch.FromDate = newBuilding.FromDate;
                    existingBatch.ToDate = newBuilding.ToDate;
                    existingBatch.IsActive = newBuilding.IsActive;
                    existingBatch.ModifiedOn = DateTime.Now;
                    existingBatch.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _batchService.UpdateBatch(existingBatch);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingBatch = await _batchService.GetBatchById(newBatch.BatchId);
            if (existingBatch == null)
            {
                return NotFound();
            }

            editBatch.BatchId = existingBuilding.BatchId;
            editBatch.BatchCode = existingBuilding.BatchCode;
            editBatch.FromDate = existingBuilding.FromDate;
            editBatch.ToDate = existingBuilding.ToDate;
            editBatch.IsActive = existingBuilding.IsActive;

            batches = await _batchService.GetBatches();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _batchService.DeleteBatch(id);
            return Page();
        }
    }
    public class Batch
    {
        public string BatchId { get; set; }
        [Required]
        [DisplayName("Batch Code")]
        public string BatchCode { get; set; } = null!;
        [Required]
        [DisplayName("Batch Start Date")]
        public DateTime FromDate { get; set; }
        [Required]
        [DisplayName("Batch End Date")]
        public DateTime ToDate { get; set; }
        public string IsActive { get; set; }
    }
}
