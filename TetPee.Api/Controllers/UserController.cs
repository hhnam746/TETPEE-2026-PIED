using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.Service.User;

namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    //cai nay nang coa luc sau se giai thich
    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    // HTTP_METHOD: GET, POST, DELETE, PUT PATCH
    // PARAM: Query String, Path Param, Body Param
    
    // Query String: http://localhost:8000/User?name=abc&age=20
        // name va query string
        // query string nam sau dau ?
        
    // PathParam/ RouteParam: http://localhost:8000/User/123
        // 123 la path param, hoac route param
        // path param nam trong duong dan
    
    // Get la khong co body
    // POST, PUT, PATCH co body
    
    // tai sao phai dung body: de tranh lo thong tin khong mong muon 
    // vdu password, username
    // khong the http://localhost:8000/login?username=abc&password=123
    
    // get all users: GET http://localhost:8000/User
    // create new user: POST http://localhost:8000/User
    // get user by id: GET http://localhost:8000/User/{id}
    // update user by id: PUT http://localhost:8000/User/{id}
    // delete user by id: DELETE http://localhost:8000/User/{id}
    
    [HttpGet("")]
    public IActionResult GetUsers([FromQuery] string? searchTerm)
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }
    
    [HttpPost("")]
    public IActionResult CreateUsers([FromBody] Request.CreateUserRequest request)
    {
        // var users = _dbContext.Users.ToList();
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password
        };
        
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        
        Console.WriteLine(request);
        return Ok("get all user");
    }
    
    [HttpGet("{id}")]
    public IActionResult GetUsersByID(Guid id)
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateUsers(Guid id, [FromBody] Request.UpdateUserRequest request)
    {
        // var users = _dbContext.Users.ToList();
        return Ok("Update User");
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteUser(Guid id)
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }
}