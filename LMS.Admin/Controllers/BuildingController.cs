using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class BuildingController : Controller
    {

        private readonly IBuildingService _buildingService;
        public BuildingController(IBuildingService buildingService)
        {
            _buildingService = buildingService;
        }
        public IActionResult Index()
        {
            IEnumerable<Building> _getBuilding = new List<Building>();
            _getBuilding = _buildingService.GetBuildings();
            return View(_getBuilding);
        }
    }
}
