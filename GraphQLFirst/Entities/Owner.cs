using System.ComponentModel.DataAnnotations;

namespace GraphQLFirst.Entities;

public class Owner
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    public string Address { get; set; }
    
    [UseSorting]
    public ICollection<Account> Accounts { get; set; }
}