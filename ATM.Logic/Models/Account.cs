namespace ATM.Logic.Models;

public class Account(int Id,
                     string Name,
                     string CardNumber,
                     string PIN,
                     decimal Balance,
                     List<CashTransaction> Transactions)
{
    public int Id { get; set; } = Id;
    public string Name { get; set; } = Name;
    public string CardNumber { get; set; } = CardNumber;
    public string PIN { get; set; } = PIN;
    public decimal Balance { get; set; } = Balance;
    public List<CashTransaction> Transactions { get; set; } = Transactions;
}
