using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IStudentSeatBookingService
    {
        Task<List<StudentSeatBooking>> GetStudentSeatBookings();
        Task<StudentSeatBooking> GetStudentSeatBookingById(string id);
        Task<int> InsertStudentSeatBooking(StudentSeatBooking studentSeatBooking);
        Task<int> UpdateStudentSeatBooking(StudentSeatBooking studentSeatBooking);
        Task<int> DeleteStudentSeatBooking(string id);
    }
}
