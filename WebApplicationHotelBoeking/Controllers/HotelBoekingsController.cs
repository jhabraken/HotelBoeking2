using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationHotelBoeking.Models;

namespace WebApplicationHotelBoeking.Controllers
{
    public class HotelBoekingsController : Controller
    {
        private readonly HotelBoekingContext _context;

        public HotelBoekingsController(HotelBoekingContext context)
        {
            _context = context;
        }

        // GET: HotelBoekings
        public async Task<IActionResult> Index()
        {
            return View(await _context.HotelBoeking.ToListAsync());
        }

        // GET: HotelBoekings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelBoeking = await _context.HotelBoeking
                .SingleOrDefaultAsync(m => m.Id == id);
            if (hotelBoeking == null)
            {
                return NotFound();
            }

            return View(hotelBoeking);
        }

        // GET: HotelBoekings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HotelBoekings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //public async Task<IActionResult> Create([Bind("Id,HotelName,Address,Booking_id,Guest_No,StartDate,EndDate,Room_No")] HotelBoeking hotelBoeking)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HotelName,Address,Booking_id,Guest_No,StartDate,EndDate,Room_No")] HotelBoeking hotelBoeking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hotelBoeking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotelBoeking);
        }

        // GET: HotelBoekings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelBoeking = await _context.HotelBoeking.SingleOrDefaultAsync(m => m.Id == id);
            if (hotelBoeking == null)
            {
                return NotFound();
            }
            return View(hotelBoeking);
        }

        // POST: HotelBoekings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HotelName,Address,Booking_id,Guest_No,StartDate,EndDate,Room_No")] HotelBoeking hotelBoeking)
        {
            if (id != hotelBoeking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelBoeking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelBoekingExists(hotelBoeking.Id))
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
            return View(hotelBoeking);
        }

        // GET: HotelBoekings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelBoeking = await _context.HotelBoeking
                .SingleOrDefaultAsync(m => m.Id == id);
            if (hotelBoeking == null)
            {
                return NotFound();
            }

            return View(hotelBoeking);
        }

        // POST: HotelBoekings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotelBoeking = await _context.HotelBoeking.SingleOrDefaultAsync(m => m.Id == id);
            _context.HotelBoeking.Remove(hotelBoeking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelBoekingExists(int id)
        {
            return _context.HotelBoeking.Any(e => e.Id == id);
        }
    }
}
