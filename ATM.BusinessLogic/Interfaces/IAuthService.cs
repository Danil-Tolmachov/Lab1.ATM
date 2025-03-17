using ATM.Logic.Models;

namespace ATM.Logic.Interfaces;

public interface IAuthService
{
    event Action OnLogin;

    Account? GetCurrentUser();

    Account? Login(string cardNumber, string pin);

    void Logout();
}
