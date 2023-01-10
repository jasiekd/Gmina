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
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Event
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventEntity>>> GetEventEntity()
        {
            return await _context.EventEntity.ToListAsync();
        }

        // GET: api/Event/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventEntity>> GetEventEntity(int id)
        {
            var eventEntity = await _context.EventEntity.FindAsync(id);

            if (eventEntity == null)
            {
                return NotFound();
            }

            return eventEntity;
        }

        // PUT: api/Event/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventEntity(int id, EventEntity eventEntity)
        {
            if (id != eventEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(eventEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventEntityExists(id))
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

        // POST: api/Event
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EventEntity>> PostEventEntity(EventEntity eventEntity)
        {
            _context.EventEntity.Add(eventEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventEntity", new { id = eventEntity.ID }, eventEntity);
        }

        // DELETE: api/Event/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventEntity(int id)
        {
            var eventEntity = await _context.EventEntity.FindAsync(id);
            if (eventEntity == null)
            {
                return NotFound();
            }

            _context.EventEntity.Remove(eventEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventEntityExists(int id)
        {
            return _context.EventEntity.Any(e => e.ID == id);
        }
    }
}
