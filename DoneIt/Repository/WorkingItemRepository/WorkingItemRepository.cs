using DoneIt.Models;
using DoneIt.Repository.WorkingItemRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoneIt.Repository.HomeRepository
{
    public class WorkingItemRepository : IWorkingItemRepository
    {
        private readonly AppDbContext _context;

        public WorkingItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<WorkingItem> DeleteAsync(string ownerId, int privateId, bool withSaveChange = true)
        {
            var workingItem = _context.WorkingItems.Where(item => item.OwnerId == ownerId && item.PrivateId == privateId).FirstOrDefault();

            if (workingItem == null)
            {
                return null;
            }

            _context.WorkingItems.Remove(workingItem);

            if (withSaveChange)
            {
                await _context.SaveChangesAsync();
            }

            return workingItem;
        }

        public async Task<List<WorkingItem>> GetAllAsync()
        {
            return await Task.Run(() =>
                _context.WorkingItems.ToList()
            );
        }

        public async Task<List<WorkingItem>> GetItems(string ownerId)
        {
            return await Task.Run(() =>
                _context.WorkingItems.Where(item => item.OwnerId == ownerId).ToList()
            );
        }

        public int GetNewPrivateId(string ownerId)
        {
            var ownersItems = _context.WorkingItems.Where(item => item.OwnerId == ownerId).ToList();

            return ownersItems.Any() ? ownersItems.Max(item => item.PrivateId) + 1 : 1;
        }

        public async Task<WorkingItem> GetWorkingItemAsync(string ownerId, int privateId)
        {
            return await Task.Run(() =>
                _context.WorkingItems.FirstOrDefault(item => item.OwnerId == ownerId && item.PrivateId == privateId)
            );
        }

        public async Task<WorkingItem> InsertAsync(WorkingItem model, bool withSaveChange = true)
        {
            _context.WorkingItems.Add(model);

            if (withSaveChange)
            {
                await _context.SaveChangesAsync();
            }

            return model;
        }

        public async Task<WorkingItem> UpdateAsync(WorkingItem model, bool withSaveChange = true)
        {
            var entry = _context.WorkingItems.Attach(model);
            entry.State = EntityState.Modified;

            if (withSaveChange)
            {
                await _context.SaveChangesAsync();
            }

            return model;
        }
    }
}
