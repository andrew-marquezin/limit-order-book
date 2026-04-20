using Domain.Entities;

namespace Domain.Repositories;

public interface IAccountRepository
{
    Task<Account?> GetAccountById(Guid id);
}