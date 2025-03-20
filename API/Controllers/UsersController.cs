using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase

{
   

    [HttpGet]
   public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
   {
    // get list of users
    var users =  await context.Users.ToListAsync();
    //return list of users to client
    return Ok(users);
   }

   
    [HttpGet("{id:int}")]
   public async Task<ActionResult<AppUser>> GetUser(int id)
   {
    // get individual user  
    var user = await context.Users.FindAsync(id);
    //check if we have user
    if(user == null) return NotFound();
    //return individual  user to client
    return Ok(user);
   }
}
