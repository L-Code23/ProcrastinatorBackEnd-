﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcrastinatorBackend.DTO;
using ProcrastinatorBackend.Models;

namespace ProcrastinatorBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ProcrastinatorDbContext dbContext = new ProcrastinatorDbContext();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<User> result = dbContext.Users.ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            User result = dbContext.Users.Find(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddUser(UserDTO newUser)
        {
            User u = new User
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                PhotoUrl = newUser.PhotoUrl,
                Display = newUser.Display,
            };

            dbContext.Users.Add(u);
            dbContext.SaveChanges();
            return Created($"/Api/User/{u.UserId}", u);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User updateUser)
        {
            if(updateUser.UserId != id) { return BadRequest(); }
            if(!dbContext.Users.Any(t => t.UserId == id)) {return NotFound(); }
            dbContext.Users.Update(updateUser);
            dbContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteUser(int id)
        {
            User u = dbContext.Users.Find(id);
            if (u == null) { return NotFound(); } 
            dbContext.Users.Remove(u);
            dbContext.SaveChanges();
            return NoContent();
         }
    }
}