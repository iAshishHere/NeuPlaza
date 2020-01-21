using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeuPlaza.Data;
using NeuPlaza.Data.Model;

namespace NeuPlaza.Api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly NeuPlazaDbContext _context;

        public UserController(NeuPlazaDbContext context)
        {
            _context = context;
        }
        //[]
        [HttpPost]
        public async Task<ActionResult<User>> PostTodoItem(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            var users = _context.Users.ToList();            
            return Ok();
        }
        /*
                [HttpPost]
                public int PostTodoItem(int x)
                {
                    //async Task<ActionResult<User>>
                    // _context.Users.Add(user);
                    //await _context.SaveChangesAsync();
                    //Console.WriteLine(user);
                    return 5;
                }*/
    }
}