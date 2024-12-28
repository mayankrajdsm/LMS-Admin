using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IBatchRepository
    {
        Task<IEnumerable<Batch>> GetBatchs();
        Task<Batch> GetBatchById(Guid batchId);
        Task<int> InsertBatch(Batch batch);
        Task<int> UpdateBatch(Batch batch);
        Task<int> DeleteBatch(Guid batchId);
    }
}
