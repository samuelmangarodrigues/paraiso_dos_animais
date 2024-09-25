using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ParaisoDosAnimais.Models;

public class Category(string name) :BaseModel
{
    [Required, MaxLength(50)] public string Name { get; set; } = name;
    public ICollection<Product> Products { get; set; } = [];
}