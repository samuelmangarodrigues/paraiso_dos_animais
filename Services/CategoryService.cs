using Microsoft.EntityFrameworkCore;
using ParaisoDosAnimais.Infrastructure.Context;
using ParaisoDosAnimais.Models;
using ParaisoDosAnimais.Services.Interfaces;
using ParaisoDosAnimais.Services.Errors;
using ParaisoDosAnimais.Dtos;
using OneOf;

namespace ParaisoDosAnimais.Services;

public class CategoryService(AppDbContext appDbContext) :ICategoryService
{
    private readonly AppDbContext _categoryContext = appDbContext;

    public async Task<OneOf<Category, AppErrors>> AddCategoryAsync(CreateCategoryDto category)
    {

        var existingCategory = await _categoryContext.Categories.
            FirstOrDefaultAsync(c => EF.Functions.Like(c.Name, category.Name));

        if (existingCategory != null)
            return new AlreadyExistsError("Category");


        var newCategory = new Category(category.Name);

        _categoryContext.Categories.Add(newCategory);
        _categoryContext.SaveChanges();

        return newCategory;
    }

    public async Task<IEnumerable<GetCategoryDto>> GetCategoriesAsync()
    {
        var categories = await _categoryContext.Categories.ToListAsync();

        var dtoCategories = categories.Select(category => new GetCategoryDto(
            category.Id,
            category.Name,
            category.Products
        ));

        return dtoCategories;

    }

    public async Task<OneOf<GetCategoryDto, AppErrors>> GetCategoryByIdAsync(Guid categoryId)
    {
        if (categoryId == Guid.Empty)
            return new GuidEmptyError();


        var category = await _categoryContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);

        if (category == null)
            return new NotFoundError("Category");

        var categoryDto = new GetCategoryDto(category.Id, category.Name, category.Products);


        return categoryDto;
    }


    public async Task<OneOf<bool, AppErrors>> DeleteCategoryAsync(Guid categoryId)
    {
        if (categoryId == Guid.Empty)
            return new GuidEmptyError();

        var categoryToBeRemove = await _categoryContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);

        if (categoryToBeRemove == null)
            return new NotFoundError("Category");


        _categoryContext.Categories.Remove(categoryToBeRemove);

        await _categoryContext.SaveChangesAsync();

        return true;

    }

    public async Task<OneOf<GetCategoryDto, AppErrors>> UpdateCategoryAsync(Guid categoryId, UpdateCategoryDto category)
    {
        if (categoryId == Guid.Empty)
            return new GuidEmptyError();

        var categoryToBeUpdated = await _categoryContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);

        if (categoryToBeUpdated == null)
            return new NotFoundError("Category");


        categoryToBeUpdated.Name = category.Name ?? categoryToBeUpdated.Name;

        await _categoryContext.SaveChangesAsync();

        var categoryUpdated = new GetCategoryDto(categoryToBeUpdated.Id, categoryToBeUpdated.Name, categoryToBeUpdated.Products);

        return categoryUpdated;

    }

}