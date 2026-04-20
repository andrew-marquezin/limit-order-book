namespace Application.UseCases.Account.GetBalance;

public class GetBalanceOutput(string username, decimal balanceBrl, decimal balanceBtc)
{
    public string Username { get; set; } = username;
    public decimal BalanceBrl { get; set; } = balanceBrl;
    public decimal BalanceBtc { get; set; } = balanceBtc;
}