using ATM.Logic.Interfaces;
using ATM.Logic.Models;

namespace ATM.Logic.Services;

public class BankService(MockDatabase mockDatabase) : IBankService
{
    public event Action OnGetBalance = delegate { };
    public event Action OnDeposit = delegate { };
    public event Action OnWithdraw = delegate { };
    public event Action OnSendToAccount = delegate { };

    public decimal GetBalance(int accountId)
    {
        var account = mockDatabase.Accounts.Find(a => a.Id == accountId)
            ?? throw new ArgumentException("Not existing account id was provided.");

        OnGetBalance?.Invoke();

        return account.Balance;
    }

    public void Deposit(int accountId, decimal ammount)
    {
        var account = mockDatabase.Accounts.Find(a => a.Id == accountId)
            ?? throw new ArgumentException("Not existing account id was provided.");

        if (account.Balance + ammount < 0)
        {
            throw new ArgumentException("Invaid cash ammount was provided.");
        }

        OnDeposit?.Invoke();

        account.Balance += ammount;
        account.Transactions.Add(new CashTransaction(ammount, DateTime.Now));
    }

    public void Withdraw(int accountId, decimal ammount)
    {
        var account = mockDatabase.Accounts.Find(a => a.Id == accountId)
            ?? throw new ArgumentException("Not existing account id was provided.");

        if (account.Balance - ammount < 0)
        {
            throw new ArgumentException("Not enough cash to process transaction.");
        }

        OnWithdraw?.Invoke();

        account.Balance -= ammount;
        account.Transactions.Add(new CashTransaction(-ammount, DateTime.Now));
    }

    public void SendToAccount(int accountIdFrom, string cardNumber, decimal ammount)
    {
        var accountFrom = mockDatabase.Accounts.Find(a => a.Id == accountIdFrom)
            ?? throw new ArgumentException("Not existing account from id was provided.");

        var accountTo = mockDatabase.Accounts.Find(a => a.CardNumber == cardNumber)
            ?? throw new ArgumentException("Not existing account to id was provided.");

        if (ammount < 0)
        {
            throw new ArgumentException("Invaid cash ammount was provided.");
        }

        if (accountFrom.Balance - ammount < 0)
        {
            throw new ArgumentException("Not enough cash to process transaction.");
        }

        OnSendToAccount?.Invoke();

        accountFrom.Balance -= ammount;
        accountFrom.Transactions.Add(new CashTransaction(-ammount, DateTime.Now));
        accountTo.Balance += ammount;
        accountTo.Transactions.Add(new CashTransaction(ammount, DateTime.Now));
    }
}
