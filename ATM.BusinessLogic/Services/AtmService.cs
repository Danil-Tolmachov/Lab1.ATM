using ATM.Logic.Interfaces;
using ATM.Logic.Models;

namespace ATM.Logic.Services;

public class AtmService(MockDatabase mockDatabase) : IAtmService
{
    public IEnumerable<Atm> GetAll()
    {
        return mockDatabase.ATMs.AsEnumerable();
    }
}
