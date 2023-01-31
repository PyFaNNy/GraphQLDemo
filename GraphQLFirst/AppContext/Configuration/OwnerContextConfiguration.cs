using GraphQLFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraphQLFirst.AppContext.Configuration;

public class OwnerContextConfiguration : IEntityTypeConfiguration<Owner>
{
    public OwnerContextConfiguration()
    {
    }

    public void Configure(EntityTypeBuilder<Owner> builder)
    {
        builder
            .HasData(
                new Owner
                {
                    Id = GuidsData.Guids[0],
                    Name = "John Doe",
                    Address = "John Doe's address"
                },
                new Owner
                {
                    Id = GuidsData.Guids[1],
                    Name = "Jane Doe",
                    Address = "Jane Doe's address"
                }
            );
    }
}