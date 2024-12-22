using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.BusinessObject;

namespace LMS.Mapper.Services
{
    public class BatchService : IBatchService
    {
        private readonly IBatchRepository _batchRepository;
        public BatchService(IBatchRepository batchRepository) => _batchRepository = batchRepository;
        public async Task<List<Batch>> GetBatches()
        {
            List<Batch> batches = new List<Batch>();
            var existingBatches = await _batchRepository.GetBatchs();
            if (existingBatches != null)
            {
                foreach (var batch in existingBatches)
                {
                    batches.Add(batch.ToBusinessObject());
                }
            }
            return batches;
        }
        public async Task<Batch> GetBatchById(string batchId)
        {
            var batch = await _batchRepository.GetBatchById(Guid.Parse(batchId));
            return batch.ToBusinessObject();
        }
        public async Task<int> InsertBatch(Batch batch) => await _batchRepository.InsertBatch(batch.ToEntityModel());
        public async Task<int> UpdateBatch(Batch batch) => await _batchRepository.UpdateBatch(batch.ToEntityModel());
        public async Task<int> DeleteBatch(string batchId) => await _batchRepository.DeleteBatch(Guid.Parse(batchId));
    }
}
