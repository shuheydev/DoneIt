using DoneIt.Repository.WorkingItemRepository;
using DoneIt.ViewModels.Dashboard;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DoneIt.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IWorkingItemRepository _workingItemRepository;

        public DashboardController(IWorkingItemRepository workingItemRepository)
        {
            _workingItemRepository = workingItemRepository;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = new DashboardIndexViewModel();
            viewModel.WorkingItems = await _workingItemRepository.GetTotalDurations();
            return View(viewModel);
        }
    }
}
