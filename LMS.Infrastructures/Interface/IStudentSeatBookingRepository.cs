using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStudentSeatBookingRepository
    {
        Task<IEnumerable<StudentSeatBooking>> GetStudentSeatBookings();
        Task<StudentSeatBooking> GetStudentSeatBookingById(Guid bookingId);
        Task<int> InsertStudentSeatBooking(StudentSeatBooking studentSeatBooking);
        Task<int> UpdateStudentSeatBooking(StudentSeatBooking studentSeatBooking);
        Task<int> DeleteStudentSeatBooking(Guid bookingId);
    }
}