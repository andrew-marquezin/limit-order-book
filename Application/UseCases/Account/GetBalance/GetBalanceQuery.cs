using Application.Abstractions.Messaging;
using Domain.Repositories;
using SharedKernel;

namespace Application.UseCases.Account.GetBalance;

public sealed record GetBalanceQuery(Guid Id) : IQuery<GetBalanceOutput>;

public sealed class GetBalanceQueryHandler(IAccountRepository repository) : IQueryHandler<GetBalanceQuery, GetBalanceOutput>
{
    public async Task<Result<GetBalanceOutput>> Handle(GetBalanceQuery query, CancellationToken cancellationToken)
    {
        var account = await repository.GetAccountById(query.Id);
        if (account is null) return Result.Failure<GetBalanceOutput>(AccountErrors.NotFound(query.Id));
        
        return Result.Success(new GetBalanceOutput(account.Username, account.BalanceBrl, account.BalanceBtc));
    }
}

public static class AccountErrors
{
    public static Error NotFound(Guid id) => new(
        "Account.NotFound",
        $"The Account with id = {id} was not found.");
}