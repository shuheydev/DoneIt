using DoneIt.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DoneIt.ViewModels.Dashboard.DashboardIndexViewModel;

namespace DoneIt.Repository.WorkingItemRepository
{
    public interface IWorkingItemRepository
    {
        public Task<List<WorkingItem>> GetAllAsync();
        public Task<WorkingItem> InsertAsync(WorkingItem item, bool withSaveChange = true);
        public int GetNewPrivateId(string ownerId);
        public Task<WorkingItem> GetWorkingItemAsync(string ownerId, int privateId);
        public Task<WorkingItem> UpdateAsync(WorkingItem item, bool withSaveChange = true);
        public Task<List<DashboardWorkingItem>> GetTotalDurations();
        public Task<WorkingItem> DeleteAsync(string ownerId, int privateId, bool withSaveChange = true);
    }
}
