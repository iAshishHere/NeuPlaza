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
    [Route("api/Question")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly NeuPlazaDbContext _context;

        public QuestionController(NeuPlazaDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Question>> PostTodoItem(Question question)
        {
            _context.Questions.Add(question);
            await _context.SaveChangesAsync();
            var users = _context.Users.ToList();
            return Ok();
        }
    }
}