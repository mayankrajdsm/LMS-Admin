using LMS.Mapper.BusinessObject;
using Microsoft.AspNetCore.Identity;

namespace LMS.Administration.Utility
{
    public class EncryptionDecryption
    {
        private readonly PasswordHasher<Staff> _passwordHasher;

        public EncryptionDecryption()
        {
            _passwordHasher = new PasswordHasher<Staff>();
        }

        // Hash the password
        public string HashPassword(string password)
        {
            return _passwordHasher.HashPassword(null, password);
        }

        // Verify the password
        public bool VerifyPassword(Staff user, string password)
        {
            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, password);
            return result == PasswordVerificationResult.Success;
        }
    }
}