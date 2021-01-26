using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KampusApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KampusApp.Pages.MahasiswaList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Model.Mahasiswa> mahasiswa { get; set; }

        public async Task OnGet()
        {
            mahasiswa = await _db.Mahasiswa.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int nim)
        {
            var mhs = await _db.Mahasiswa.FindAsync(nim);
            if (mhs == null)
            {
                return NotFound();
            }
            else
            {
                _db.Mahasiswa.Remove(mhs);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
        }
    }
}
