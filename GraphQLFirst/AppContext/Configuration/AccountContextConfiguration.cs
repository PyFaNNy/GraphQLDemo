using GraphQLFirst.Entities;
using GraphQLFirst.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQLFirst.AppContext.Configuration;

public class AccountContextConfiguration : IEntityTypeConfiguration<Account>
{
    public AccountContextConfiguration()
    {
    }

    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder
            .HasData(
                new Account
                {
                    Id = Guid.NewGuid(),
                    Type = TypeOfAccount.Cash,
                    Description = "Cash account for our users",
                    OwnerId = GuidsData.Guids[0]
                },
                new Account
                {
                    Id = Guid.NewGuid(),
                    Type = TypeOfAccount.Savings,
                    Description = "Savings account for our users",
                    OwnerId = GuidsData.Guids[1]
                },
                new Account
                {
                    Id = Guid.NewGuid(),
                    Type = TypeOfAccount.Income,
                    Description = "Income account for our users",
                    OwnerId = GuidsData.Guids[1]
                }
            );
    }
}