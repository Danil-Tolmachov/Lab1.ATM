namespace ATM.Logic.Interfaces;

public interface IBankService
{
    event Action OnGetBalance;
    event Action OnDeposit;
    event Action OnWithdraw;
    event Action OnSendToAccount;

    decimal GetBalance(int accountId);

    void Deposit(int accountId, decimal ammount);

    void Withdraw(int accountId, decimal ammount);

    void SendToAccount(int accountIdFrom, string cardNumber, decimal ammount);
}
