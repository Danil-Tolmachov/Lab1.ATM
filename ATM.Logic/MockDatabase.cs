using ATM.Logic.Models;

namespace ATM.Logic;

public class MockDatabase
{
    public List<Account> Accounts { get; init; } =
    [
        new Account(1, "User 1", "123456789", "1111", 100, [new(-100, DateTime.Now)]),
        new Account(2, "User 2", "234567890", "2222", 200, [new(-100, DateTime.Now)]),
        new Account(3, "User 3", "345678901", "3333", 300, [new(-100, DateTime.Now)]),
    ];

    public List<Atm> ATMs { get; init; } =
    [
        new Atm(1, "st. Test 1, 123"),
        new Atm(2, "st. Test 2, 1"),
        new Atm(3, "st. Test 3, 2"),
        new Atm(4, "st. Test 4, 3"),
    ];
}
