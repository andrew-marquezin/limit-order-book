using Domain.Primitives;

namespace Domain.Entities;

public class Account(Guid id, string username, decimal balanceBrl, decimal balanceBtc) : Entity(id)
{
    public string Username { get; private set; } = username;
    public decimal BalanceBrl { get; private set; } = balanceBrl;
    public decimal BalanceBtc { get; private set; } = balanceBtc;
}
