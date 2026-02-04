using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.User;

namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController:ControllerBase
{
    private readonly AppDbContext _dbContext;
    public CategoryController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost("")]
    public IActionResult CreateCategory([FromBody] Request.CreateCategoryRequest request)
    {
        var category = new Category
        {
            Name = request.Name
        };
        
        _dbContext.Categories.Add(category);
        _dbContext.SaveChanges();
        
        Console.WriteLine(request);
        return Ok(category);
    }
    
    [HttpGet("")]
    public IActionResult GetCategoriesParents(Guid categoryId)
    {
        var categories = _dbContext.Categories.ToList();
        return Ok(categories);
    }

    [HttpPut("{categoryId}")]
    public IActionResult UpdateCategory(Guid id, [FromBody] Request.UpdateCategoryRequest request)
    {
        
        return Ok("Updated successfully");
    }
}