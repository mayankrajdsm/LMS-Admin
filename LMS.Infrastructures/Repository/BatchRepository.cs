using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class BatchRepository: IBatchRepository
    {
        private readonly TestContext _context;
        public BatchRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<Batch>> GetBatchs() => await _context.Batches.ToListAsync();
        public async Task<Batch> GetBatchById(Guid batchId) => await _context.Batches.FindAsync(batchId);
        public async Task<int> InsertBatch(Batch batch)
        {
            _context.Batches.Add(batch);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateBatch(Batch batch)
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteBatch(Guid batchId)
        {
            var batch = await _context.Batches.FindAsync(batchId);
            _context.Batches.Remove(batch);
            return await _context.SaveChangesAsync();
        }
    }
}
