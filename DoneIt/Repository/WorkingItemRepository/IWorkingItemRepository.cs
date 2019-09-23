using DoneIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoneIt.Repository.WorkingItemRepository
{
    public interface IWorkingItemRepository
    {
        public Task<List<WorkingItem>> GetAllAsync();
        public Task<WorkingItem> InsertAsync(WorkingItem item, bool withSaveChange = true);
        public int GetNewPrivateId(string ownerId);
        public Task<WorkingItem> GetWorkingItemAsync(string ownerId, int privateId);
        public Task<WorkingItem> UpdateAsync(WorkingItem item, bool withSaveChange = true);
        public Task<WorkingItem> DeleteAsync(string ownerId, int privateId, bool withSaveChange = true);
    }
}
