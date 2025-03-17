using ATM.Logic.Interfaces;
using ATM.Logic.Models;

namespace ATM.Logic.Services;

public class AuthService(MockDatabase mockDatabase) : IAuthService
{
    public event Action OnLogin = delegate { };

    private Account? CurrentUser { get; set; }

    public Account? GetCurrentUser() => CurrentUser;
    public void Logout() => CurrentUser = null;

    public Account? Login(string cardNumber, string pin)
    {
        var user = mockDatabase.Accounts.Find(u => u.CardNumber == cardNumber
                                                && u.PIN == pin);

        OnLogin?.Invoke();

        CurrentUser = user;
        return user;
    }
}
