using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess.Repositories;

public class AccountRepository(ApplicationDbContext context) : IAccountRepository
{
    public Task<Account?> GetAccountById(Guid id) => context.Accounts.FirstOrDefaultAsync(x => x.Id == id);
}