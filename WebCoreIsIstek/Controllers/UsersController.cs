using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCoreIsIstek.Core.Entities;
using WebCoreIsIstek.Infrastructure.Data;
using WebCoreIsIstek.Infrastructure.Repository;

namespace WebCoreIsIstek.Controllers
{
    public class UsersController : Controller
    {
        private   WebCoreIsIstekContext _context;
 
        public UsersController(WebCoreIsIstekContext context)
        {
            _context = context;
            
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            UsersRepository ur = new UsersRepository(_context);

            var st = await ur.GetAllUsersAsync();
            return View(await _context.TbUsers.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsers = await _context.TbUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (tbUsers == null)
            {
                return NotFound();
            }

            return View(tbUsers);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,UserName,PassWord,Type,Email,Photo,IsActive,RolGroups,Id")] TbUsers tbUsers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbUsers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbUsers);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsers = await _context.TbUsers.FindAsync(id);
            if (tbUsers == null)
            {
                return NotFound();
            }
            return View(tbUsers);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,UserName,PassWord,Type,Email,Photo,IsActive,RolGroups,Id")] TbUsers tbUsers)
        {
            if (id != tbUsers.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbUsers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbUsersExists(tbUsers.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tbUsers);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsers = await _context.TbUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (tbUsers == null)
            {
                return NotFound();
            }

            return View(tbUsers);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbUsers = await _context.TbUsers.FindAsync(id);
            _context.TbUsers.Remove(tbUsers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbUsersExists(int id)
        {
            return _context.TbUsers.Any(e => e.UserId == id);
        }


    }
}
