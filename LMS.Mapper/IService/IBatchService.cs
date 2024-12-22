using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IBatchService
    {
        Task<List<Batch>> GetBatches();
        Task<Batch> GetBatchById(string batchId);
        Task<int> InsertBatch(Batch batch);
        Task<int> UpdateBatch(Batch batch);
        Task<int> DeleteBatch(string batchId);
    }
}
