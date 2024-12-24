using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class StudentSeatBookingRepository : IStudentSeatBookingRepository
    {
        private readonly TestContext _context;

        public StudentSeatBookingRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<StudentSeatBooking>> GetStudentSeatBookings() => await _context.StudentSeatBookings.ToListAsync();
        public async Task<StudentSeatBooking> GetStudentSeatBookingById(Guid bookingId) => await _context.StudentSeatBookings.FindAsync(bookingId);
        public async Task<int> InsertStudentSeatBooking(StudentSeatBooking studentSeatBooking)
        {
            _context.StudentSeatBookings.Add(studentSeatBooking);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStudentSeatBooking(StudentSeatBooking studentSeatBooking)
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteStudentSeatBooking(Guid bookingId)
        {
            var bookinng = await _context.StudentSeatBookings.FindAsync(bookingId);
            _context.StudentSeatBookings.Remove(bookinng);
            return await _context.SaveChangesAsync();
        }
    }
}
