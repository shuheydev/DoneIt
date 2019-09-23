using DoneIt.Models;
using DoneIt.Repository.WorkingItemRepository;
using DoneIt.ViewModels.WorkingItem;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DoneIt.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class WorkingItemController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWorkingItemRepository _workingItemRepository;

        public WorkingItemController(ILogger<HomeController> logger,
            IWorkingItemRepository workingItemRepository)
        {
            _logger = logger;
            _workingItemRepository = workingItemRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = await _workingItemRepository.GetAllAsync();

            var model = new WorkingItemIndexViewModel(items);

            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkingItemCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var ownerId = User.Identity.Name;
            var privateId = _workingItemRepository.GetNewPrivateId(ownerId);

            WorkingItem model = new WorkingItem
            {
                PrivateId = privateId,
                OwnerId = ownerId,
                Name = viewModel.Name,
                Description = viewModel.Description,
                From = viewModel.DateTimeFrom,
                To = viewModel.DateTimeTo,
            };

            var result = await _workingItemRepository.InsertAsync(model, true);

            return RedirectToAction("index", "workingitem");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int privateId)
        {
            var workingItem = await _workingItemRepository.GetWorkingItemAsync(User.Identity.Name, privateId);

            if (workingItem == null)
            {
                return NotFound();
            }

            var viewModel = new WorkingItemEditViewModel(workingItem);

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(WorkingItemEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            string ownerId = User.Identity.Name;

            var item = await _workingItemRepository.GetWorkingItemAsync(ownerId, viewModel.PrivateId);

            if (item == null)
            {
                return NotFound();
            }

            item.Name = viewModel.Name;
            item.Description = viewModel.Description;
            item.From = viewModel.DateTimeFrom;
            item.To = viewModel.DateTimeTo;

            var result = await _workingItemRepository.UpdateAsync(item);

            return RedirectToAction("index", "workingitem");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int privateId)
        {
            var workingItem = await _workingItemRepository.GetWorkingItemAsync(User.Identity.Name, privateId);

            if (workingItem == null)
            {
                return NotFound();
            }

            var viewModel = new WorkingItemDeleteViewModel(workingItem);

            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int privateId)
        {
            var model = await _workingItemRepository.DeleteAsync(User.Identity.Name, privateId);

            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int privateId)
        {
            var workingItem = await _workingItemRepository.GetWorkingItemAsync(User.Identity.Name, privateId);

            if (workingItem == null)
            {
                return NotFound();
            }

            var viewModel = new WorkingItemDetailViewModel(workingItem);

            return View(viewModel);
        }
    }
}
