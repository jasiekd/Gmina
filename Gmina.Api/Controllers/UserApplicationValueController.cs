using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GminaApi.Data;

namespace Gmina_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApplicationValueController : ControllerBase
    {
        private readonly DataContext _context;

        public UserApplicationValueController(DataContext context)
        {
            _context = context;
        }

        // GET: api/UserApplicationValue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserApplicationValueEntity>>> GetUserApplicationValues()
        {
            return await _context.UserApplicationValues.ToListAsync();
        }

        // GET: api/UserApplicationValue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserApplicationValueEntity>> GetUserApplicationValueEntity(int id)
        {
            var userApplicationValueEntity = await _context.UserApplicationValues.FindAsync(id);

            if (userApplicationValueEntity == null)
            {
                return NotFound();
            }

            return userApplicationValueEntity;
        }

        // PUT: api/UserApplicationValue/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserApplicationValueEntity(int id, UserApplicationValueEntity userApplicationValueEntity)
        {
            if (id != userApplicationValueEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(userApplicationValueEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserApplicationValueEntityExists(id))
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

        // POST: api/UserApplicationValue
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserApplicationValueEntity>> PostUserApplicationValueEntity(UserApplicationValueEntity userApplicationValueEntity)
        {
            _context.UserApplicationValues.Add(userApplicationValueEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserApplicationValueEntity", new { id = userApplicationValueEntity.ID }, userApplicationValueEntity);
        }

        // DELETE: api/UserApplicationValue/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserApplicationValueEntity(int id)
        {
            var userApplicationValueEntity = await _context.UserApplicationValues.FindAsync(id);
            if (userApplicationValueEntity == null)
            {
                return NotFound();
            }

            _context.UserApplicationValues.Remove(userApplicationValueEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserApplicationValueEntityExists(int id)
        {
            return _context.UserApplicationValues.Any(e => e.ID == id);
        }

        // GET: api/UserApplicationValue/GetFor/5
        [HttpGet("GetFor/{id}")]
        public async Task<ActionResult<UserApplicationValueEntity>> GetValuesApplication(int id)
        {
            var valuesApplication = _context.UserApplicationValues.Where(e => e.UserApplicationId == id).ToList();

            if (valuesApplication == null)
            {
                return NotFound();
            }

            return Ok(valuesApplication);
        }
    }
}
