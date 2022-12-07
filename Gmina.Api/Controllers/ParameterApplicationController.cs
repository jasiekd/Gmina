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
    public class ParameterApplicationController : ControllerBase
    {
        private readonly DataContext _context;

        public ParameterApplicationController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ParameterApplication
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParameterApplicationEntity>>> GetParametersApplication()
        {
            return await _context.ParametersApplication.ToListAsync();
        }

        // GET: api/ParameterApplication/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParameterApplicationEntity>> GetParameterApplicationEntity(int id)
        {
            var parameterApplicationEntity = await _context.ParametersApplication.FindAsync(id);

            if (parameterApplicationEntity == null)
            {
                return NotFound();
            }

            return parameterApplicationEntity;
        }

        // PUT: api/ParameterApplication/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParameterApplicationEntity(int id, ParameterApplicationEntity parameterApplicationEntity)
        {
            if (id != parameterApplicationEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(parameterApplicationEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParameterApplicationEntityExists(id))
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

        // POST: api/ParameterApplication
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ParameterApplicationEntity>> PostParameterApplicationEntity(ParameterApplicationEntity parameterApplicationEntity)
        {
            _context.ParametersApplication.Add(parameterApplicationEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParameterApplicationEntity", new { id = parameterApplicationEntity.ID }, parameterApplicationEntity);
        }

        // DELETE: api/ParameterApplication/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParameterApplicationEntity(int id)
        {
            var parameterApplicationEntity = await _context.ParametersApplication.FindAsync(id);
            if (parameterApplicationEntity == null)
            {
                return NotFound();
            }

            _context.ParametersApplication.Remove(parameterApplicationEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParameterApplicationEntityExists(int id)
        {
            return _context.ParametersApplication.Any(e => e.ID == id);
        }

        // GET: api/ParameterApplication/GetFor/5
        [HttpGet("GetFor/{id}")]
        public async Task<ActionResult<ParameterApplicationEntity>> GetParametersApplication(int id)
        {
            var parametersApplication = _context.ParametersApplication.Where(e => e.ApplicationId == id).ToList();

            if (parametersApplication == null)
            {
                return NotFound();
            }

            return Ok(parametersApplication);
        }

    }
}
