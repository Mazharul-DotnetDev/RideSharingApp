using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorAppServer.DataContext;
using BlazorAppServer.Models;

namespace BlazorAppServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly RideShareDb _context;

        public UsersController(RideShareDb context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.Include(c => c.Rides).ToListAsync();
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _context.Users.Include(c => c.Rides).FirstOrDefaultAsync(c => c.UserId == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user
            )
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

			if (ModelState.IsValid)
            {
				try
				{
					_context.Update(user);

					var itemsIdList = user.Rides.Select(i => i.RideId).ToList();

					var delItems = await _context.Rides.Where(i => i.UserId == id).Where(i => !itemsIdList.Contains(i.RideId)).ToListAsync();

					_context.Rides.RemoveRange(delItems);


					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!UserExists(id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}

				return NoContent();
			}

			return BadRequest(ModelState);

		}

        
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
			if (ModelState.IsValid)
            {
				_context.Users.Add(user);
				await _context.SaveChangesAsync();

				return CreatedAtAction("GetUsers", new { id = user.UserId }, user);
			}

			return BadRequest(ModelState);

		}

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
