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
    public class StateRepository: IStateRepository
    {
        private readonly FunskoolsContext _context;
        public StateRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<State>> GetStates() => await _context.States.ToListAsync();
        public async Task<State> GetStateById(Guid id) => await _context.States.FindAsync(id);
        public async Task<int> InsertState(State state)
        {
            _context.States.Add(state);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateState(State state) => await _context.SaveChangesAsync();
        public async Task<int> DeleteState(Guid id)
        {
            var state = await _context.States.FindAsync(id);
            _context.States.Remove(state);
            return await _context.SaveChangesAsync();
        }
    }
}
