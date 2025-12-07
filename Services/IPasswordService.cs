using Entities;

namespace Services
{
    public interface IPasswordService
    {
        PasswordEntity getStrengthByPass(string password);
    }
}