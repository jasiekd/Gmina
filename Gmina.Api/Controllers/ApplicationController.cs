using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GminaApi.Data;
using Gmina_Api.Entity;

namespace Gmina_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly DataContext _context;

        public ApplicationController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Application
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationEntity>>> GetApplications()
        {
            return await _context.Applications.ToListAsync();
        }

        // GET: api/Application/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationEntity>> GetApplicationEntity(int id)
        {
            var applicationEntity = await _context.Applications.FindAsync(id);

            if (applicationEntity == null)
            {
                return NotFound();
            }

            return applicationEntity;
        }

        // PUT: api/Application/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationEntity(int id, ApplicationEntity applicationEntity)
        {
            if (id != applicationEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(applicationEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationEntityExists(id))
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

        // POST: api/Application
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApplicationEntity>> PostApplicationEntity(ApplicationEntity applicationEntity)
        {
            _context.Applications.Add(applicationEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplicationEntity", new { id = applicationEntity.ID }, applicationEntity);
        }

        // DELETE: api/Application/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationEntity(int id)
        {
            var applicationEntity = await _context.Applications.FindAsync(id);
            if (applicationEntity == null)
            {
                return NotFound();
            }

            _context.Applications.Remove(applicationEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApplicationEntityExists(int id)
        {
            return _context.Applications.Any(e => e.ID == id);
        }
    }
}
