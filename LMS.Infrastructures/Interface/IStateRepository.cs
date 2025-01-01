using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStateRepository
    {
        Task<IEnumerable<State>> GetStates();
       Task<State> GetStateById(Guid id);
        Task<int> InsertState(State state);
       Task<int> UpdateState(State state);
        Task<int> DeleteState(Guid id);
    }
}
