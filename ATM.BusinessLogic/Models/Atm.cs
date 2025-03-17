namespace ATM.Logic.Models
{
    public class Atm(int id, string address)
    {
        public int Id { get; set; } = id;
        public string Address { get; set; } = address;

    }
}
