using ATM.Logic.Models;

namespace ATM.Logic.Interfaces;

public interface IAtmService
{
    IEnumerable<Atm> GetAll();
}
