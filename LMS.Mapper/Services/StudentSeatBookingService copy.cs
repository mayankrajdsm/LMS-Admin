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
    public class StudentSeatBookingService : IStudentSeatBookingService
    {
        private readonly IStudentSeatBookingRepository _studentSeatBookingRepository;

        public StudentSeatBookingService(IStudentSeatBookingRepository studentSeatBookingRepository) => _studentSeatBookingRepository = studentSeatBookingRepository;

        public async Task<List<StudentSeatBooking>> GetStudentSeatBookings()
        {
            List<StudentSeatBooking> studentSeatBookings = new List<StudentSeatBooking>();
            var existingStudentSeatBookings = await _studentSeatBookingRepository.GetStudentSeatBookings();
            if (existingStudentSeatBookings != null)
            {
                foreach (var studentSeatBooking in existingStudentSeatBookings)
                {
                    studentSeatBookings.Add(studentSeatBooking.ToBusinessObject());
                }
            }
            return studentSeatBookings;
        }
        public async Task<StudentSeatBooking> GetStudentSeatBookingById(string id)
        {
            var studentSeatBooking = await _studentSeatBookingRepository.GetStudentSeatBookingById(Guid.Parse(id));
            return studentSeatBooking.ToBusinessObject();
        }
        public async Task<int> InsertStudentSeatBooking(StudentSeatBooking studentSeatBooking) => await _studentSeatBookingRepository.InsertStudentSeatBooking(studentSeatBooking.ToEntityModel());
        public async Task<int> UpdateStudentSeatBooking(StudentSeatBooking studentSeatBooking) => await _studentSeatBookingRepository.UpdateStudentSeatBooking(studentSeatBooking.ToEntityModel());
        public async Task<int> DeleteStudentSeatBooking(string id) => await _studentSeatBookingRepository.DeleteStudentSeatBooking(Guid.Parse(id));
    }
}
