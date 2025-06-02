using System;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[Authorize]
public class UsersController(IUserRepository userRepository) : BaseApiController

{


    [HttpGet]

    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
    {
        // get list of users
        var users = await userRepository.GetMembersAsync();

        //return list of users to client
        return Ok(users);
    }


    [HttpGet("{username}")]

    public async Task<ActionResult<MemberDto>> GetUser(string username)
    {
        // get individual user  
        var user = await userRepository.GetMemberAsync(username);
        //check if we have user
        if (user == null) return NotFound();
        //return individual  user to client
        return Ok(user);

    }
}
