using ParaisoDosAnimais.Models;

namespace ParaisoDosAnimais.Dtos;


public record CreateCategoryDto(string Name);
public record GetCategoryDto(Guid Id, string Name, ICollection<Product> Products);
public record UpdateCategoryDto(string? Name);