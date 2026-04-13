using System.ComponentModel.DataAnnotations.Schema;
using Domain.Primitives;

namespace Domain.Entities;

[Table("accounts")]
public class Account : Entity
{
    [Column("balance_brl")]
    public decimal BalanceBrl { get; set; }
    
    [Column("balance_btc")]
    public decimal BalanceBtc { get; set; }
}