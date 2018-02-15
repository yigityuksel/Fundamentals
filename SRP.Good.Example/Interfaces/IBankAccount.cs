namespace SRP.Good.Example.Interfaces
{
    public interface IBankAccount
    {
        string AccountName { get; set; }

        decimal AccountBalance { get; set; }
    }
}