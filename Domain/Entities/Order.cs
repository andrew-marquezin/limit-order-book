using Domain.Enums;
using Domain.Primitives;

namespace Domain.Entities;

public class Order(Guid id,
    Guid ownerId,
    OrderType type,
    OrderStatus status,
    decimal priceBrl,
    decimal priceBtc) : Entity(id)
{
    public Guid OwnerId { get; private set; }
    public OrderType Type { get; private set; }
    public OrderStatus Status { get; private set; }
    public decimal PriceBrl { get; private set; }
    public decimal PriceBtc { get; private set; }
}