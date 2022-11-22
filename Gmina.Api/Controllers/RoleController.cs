using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GminaApi.Data;
using GminaApi.Entity;

namespace GminaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly DataContext _context;

        public RoleController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Role
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleEntity>>> GetRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        // GET: api/Role/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoleEntity>> GetRoleEntity(int id)
        {
            var roleEntity = await _context.Roles.FindAsync(id);

            if (roleEntity == null)
            {
                return NotFound();
            }

            return roleEntity;
        }

        // PUT: api/Role/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoleEntity(int id, RoleEntity roleEntity)
        {
            if (id != roleEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(roleEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleEntityExists(id))
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

        // POST: api/Role
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RoleEntity>> PostRoleEntity(RoleEntity roleEntity)
        {
            _context.Roles.Add(roleEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoleEntity", new { id = roleEntity.ID }, roleEntity);
        }

        // DELETE: api/Role/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleEntity(int id)
        {
            var roleEntity = await _context.Roles.FindAsync(id);
            if (roleEntity == null)
            {
                return NotFound();
            }

            _context.Roles.Remove(roleEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoleEntityExists(int id)
        {
            return _context.Roles.Any(e => e.ID == id);
        }
    }
}
