using Microsoft.AspNetCore.Identity;

namespace ParaisoDosAnimais.Models;

public class Client(string name):IdentityUser
{
    public string Name { get; set; } = name;
    public ICollection<Address> Addresses { get; set; } = [];
    public Cart? Cart { get; set; }

}
