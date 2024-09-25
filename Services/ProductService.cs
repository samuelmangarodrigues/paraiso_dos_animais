using Microsoft.EntityFrameworkCore;
//using ParaisoDosAnimais.Dtos;
using ParaisoDosAnimais.Infrastructure.Context;
using ParaisoDosAnimais.Models;
using ParaisoDosAnimais.Services.Interfaces;
using ParaisoDosAnimais.Services.Validations;
using System.Xml.Linq;


namespace ParaisoDosAnimais.Services;

public class ProductService(AppDbContext appDbContext, CategoryService categoryService)
{
    private readonly AppDbContext _productDbContext = appDbContext;
    private readonly CategoryService _categoryService = categoryService;

    public void CreateProduct(string name, string description, Guid categoryId, int quantity, decimal price)
    {
    }

    public void GetAllProducts()
    {
    }

    public void GetProductById(Guid id)
    {

    }

    public bool UpdateProduct(Guid productId, string productDto)
    {
        return false;
    }

    public bool DeleteProduct(Guid productId)
    {

        return true;
    }
}