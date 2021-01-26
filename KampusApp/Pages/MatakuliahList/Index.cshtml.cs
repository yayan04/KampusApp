using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KampusApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KampusApp.Pages.MatakuliahList
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Matakuliah> matakuliah { get; set; }

        public async Task OnGet()
        {
            matakuliah = await _db.Matakuliah.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var mtk = await _db.Matakuliah.FindAsync(id);
            if(mtk == null)
            {
                return NotFound();
            }
            else
            {
                _db.Matakuliah.Remove(mtk);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
        }
    }
}
