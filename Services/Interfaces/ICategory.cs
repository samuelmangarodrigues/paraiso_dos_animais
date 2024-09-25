using OneOf;
using ParaisoDosAnimais.Dtos;
using ParaisoDosAnimais.Models;
using ParaisoDosAnimais.Services.Errors;

namespace ParaisoDosAnimais.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<OneOf<Category, AppErrors>> AddCategoryAsync(CreateCategoryDto category);
        Task<IEnumerable<GetCategoryDto>> GetCategoriesAsync();
        Task<OneOf<GetCategoryDto, AppErrors>> GetCategoryByIdAsync(Guid categoryId);
        Task<OneOf<bool, AppErrors>> DeleteCategoryAsync(Guid categoryId);
        Task<OneOf<GetCategoryDto, AppErrors>> UpdateCategoryAsync(Guid categoryId, UpdateCategoryDto category);

    }
}
