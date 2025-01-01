using LMS.Administration.Middleware;
using LMS.Administration.Pages.Staff;
using LMS.Infrastructures.Models;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMS.Administration.Pages.Infrastructure
{
    public class BuildingModel : PageModel
    {
        private readonly ILogger<BuildingModel> _logger;
        private readonly IBuildingService _buildingService;
        private readonly IActiveUserService _activeUserService;
        public BuildingModel(ILogger<BuildingModel> logger, IBuildingService buildingService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _buildingService = buildingService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.Building> buildings { get; set; }
        [BindProperty]
        public Building newBuilding { get; set; }
        [BindProperty]
        public Building editBuilding { get; set; }
        public async Task<IActionResult> OnGet()
        {
            List<LMS.Mapper.BusinessObject.Building> lstBuildings = new List<LMS.Mapper.BusinessObject.Building>();
            lstBuildings = await _buildingService.GetBuildings();
            buildings = lstBuildings;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                buildings = await _buildingService.GetBuildings();
                return Page();
            }

            if (string.IsNullOrEmpty(newBuilding.BuildingId))
            {
                LMS.Mapper.BusinessObject.Building building = new Mapper.BusinessObject.Building();
                building.BuildingName = newBuilding.BuildingName;
                building.Address1 = newBuilding.Address1;
                building.Address2 = newBuilding.Address2;
                building.CountryId = newBuilding.CountryId;
                building.StateId = newBuilding.StateId;
                building.CityId = newBuilding.CityId;
                building.ContactPerson = newBuilding.ContactPerson;
                building.ContactNo = newBuilding.ContactNo;
                building.ContactEmail = newBuilding.ContactEmail;
                building.IsActive = true;
                building.CreatedOn = DateTime.Now;
                building.CreatedBy = _activeUserService.UserId;
                int isSave = await _buildingService.InsertBuilding(building);
            }
            else
            {
                var existingBuilding = await _buildingService.GetBuildingById(newBuilding.BuildingId);
                if (existingBuilding != null)
                {
                    existingBuilding.BuildingName = newBuilding.BuildingName;
                    existingBuilding.Address1 = newBuilding.Address1;
                    existingBuilding.Address2 = newBuilding.Address2;
                    existingBuilding.CountryId = newBuilding.CountryId;
                    existingBuilding.StateId = newBuilding.StateId;
                    existingBuilding.CityId = newBuilding.CityId;
                    existingBuilding.ContactPerson = newBuilding.ContactPerson;
                    existingBuilding.ContactNo = newBuilding.ContactNo;
                    existingBuilding.ContactEmail = newBuilding.ContactEmail;
                    existingBuilding.ModifiedOn = DateTime.Now;
                    existingBuilding.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _buildingService.UpdateBuilding(existingBuilding);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingBuilding = await _buildingService.GetBuildingById(id);
            if (existingBuilding == null)
            {
                return NotFound();
            }

            editBuilding.BuildingId = existingBuilding.BuildingId;
            editBuilding.DomainId = existingBuilding.DomainId;
            editBuilding.BuildingName = existingBuilding.BuildingName;
            editBuilding.Address1 = existingBuilding.Address1;
            editBuilding.Address2 = existingBuilding.Address2;
            editBuilding.CountryId = existingBuilding.CountryId;
            editBuilding.StateId = existingBuilding.StateId;
            editBuilding.CityId = existingBuilding.CityId;
            editBuilding.ContactPerson = existingBuilding.ContactPerson;
            editBuilding.ContactNo = existingBuilding.ContactNo;
            editBuilding.ContactEmail = existingBuilding.ContactEmail;
            buildings = await _buildingService.GetBuildings();
            return Page();
        }
    }
    public class Building
    {
        public string DomainId { get; set; } = null!;
        public List<SelectListItem> lstDomains { get; set; }
        public string BuildingId { get; set; } = null!;
        public string BuildingName { get; set; } = null!;
        public string BuildingInitial { get; set; } = null!;
        public string InstituteCode { get; set; } = null!;
        public string InstituteType { get; set; } = null!;
        public string StartingReciptNumber { get; set; } = null!;
        public string Website { get; set; } = null!;
        public string Address1 { get; set; } = null!;

        public string Address2 { get; set; } = null!;

        public string CountryId { get; set; }
        public List<SelectListItem> lstCountry { get; set; }
        public string CountryName { get; set; }
        public string StateId { get; set; }
        public List<SelectListItem> lstState { get; set; }

        public string CityId { get; set; }
        public List<SelectListItem> lstCity { get; set; }

        public string ContactPerson { get; set; } = null!;

        public string ContactNo { get; set; } = null!;

        public string ContactEmail { get; set; } = null!;
        public string Currency { get; set; } = null!;
    }
}
