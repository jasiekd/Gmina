﻿using System;
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
    public class UserApplicationController : ControllerBase
    {
        private readonly DataContext _context;

        public UserApplicationController(DataContext context)
        {
            _context = context;
        }

        // GET: api/UserApplication
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserApplicationEntity>>> GetUsersApplications()
        {
            return await _context.UsersApplications.ToListAsync();
        }
        [HttpGet("ForClerk/{id}")]
        public async Task<ActionResult<IEnumerable<UserApplicationEntity>>> GetUsersApplicationsForClerk(int id)
        {
            return await _context.UsersApplications.Where(x=> (x.Status == "Submitted" || x.Status == "Improvement") && (x.ClerkId==0 || x.ClerkId==id)).ToListAsync();
        }
        // GET: api/UserApplication/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserApplicationEntity>> GetUserApplicationEntity(int id)
        {
            var userApplicationEntity = await _context.UsersApplications.FindAsync(id);

            if (userApplicationEntity == null)
            {
                return NotFound();
            }

            return userApplicationEntity;
        }

        // PUT: api/UserApplication/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserApplicationEntity(int id, UserApplicationEntity userApplicationEntity)
        {
            if (id != userApplicationEntity.ID)
            {
                return BadRequest();
            }

            _context.Entry(userApplicationEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserApplicationEntityExists(id))
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

        // POST: api/UserApplication
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserApplicationEntity>> PostUserApplicationEntity(UserApplicationEntity userApplicationEntity)
        {
            _context.UsersApplications.Add(userApplicationEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserApplicationEntity", new { id = userApplicationEntity.ID }, userApplicationEntity);
        }

        // DELETE: api/UserApplication/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserApplicationEntity(int id)
        {
            var userApplicationEntity = await _context.UsersApplications.FindAsync(id);
            if (userApplicationEntity == null)
            {
                return NotFound();
            }

            _context.UsersApplications.Remove(userApplicationEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserApplicationEntityExists(int id)
        {
            return _context.UsersApplications.Any(e => e.ID == id);
        }

        [HttpGet("LastApplication/{userId}")]
        public async Task<ActionResult<int>> GetLastApplicationForUser(int userId)
        {
            var lastApplicationEntity = _context.UsersApplications.Where(z=>z.UserId==userId)
                                                                  .OrderBy(z=>z.DatePosted)                                                   
                                                                  .LastOrDefault();

            if (lastApplicationEntity == null)
            {
                return NotFound();
            }

            return lastApplicationEntity.ID;
        }


        // POST: api/UserApplication/ChangeStatus/2/accepted
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpGet("ChangeStatus/{id}/{status}/{clerkId}")]
        public async Task<ActionResult<UserApplicationEntity>> GetChangeStatusUserApplicationEntity(int id, string status, int clerkId)
        {
            UserApplicationEntity temp = await _context.UsersApplications.FindAsync(id);
            temp.Status = status;
            temp.ClerkId = clerkId;
            temp.DateModified = DateTime.Now;
            _context.UsersApplications.Update(temp);
            await _context.SaveChangesAsync();

            return temp;
        }

        // POST: api/UserApplication/ChangeStatus/2/accepted
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpGet("GetForUser/{id}")]
        public async Task<ActionResult<IEnumerable<UserApplicationEntity>>> GetUserApplicationForUserEntity(int id)
        {
            return await _context.UsersApplications.Where(x=>x.UserId==id).ToListAsync();
        }
        [HttpGet("GetForUserExisting/{id}")]
        public async Task<ActionResult<IEnumerable<UserApplicationEntity>>> GetUserApplicationForUserEntityExisting(int id)
        {
            return await _context.UsersApplications.Where(x => x.UserId == id).Where(x=> x.Status!="Deleted").ToListAsync();
        }
        [HttpGet("StatusOnDeleted/{id}")]
        public async Task<ActionResult<UserApplicationEntity>> GetChangeStatusOnDeleted(int id)
        {
            UserApplicationEntity temp = await _context.UsersApplications.FindAsync(id);
            temp.Status = "Deleted";
            temp.DateModified = DateTime.Now;
            _context.UsersApplications.Update(temp);
            await _context.SaveChangesAsync();

            return temp;
        }
    }
}
