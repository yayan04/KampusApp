using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KampusApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KampusApp.Pages.AkademikList
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Model.Mahasiswa> mahasiswa { get; set; }

        public IEnumerable<Model.Matakuliah> matakuliah { get; set; }


        [BindProperty]
        public Akademik akademik { get; set; }


        public async Task OnGet()
        {
            mahasiswa = await _db.Mahasiswa.ToListAsync();

            matakuliah = await _db.Matakuliah.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var mh = await _db.Mahasiswa.FindAsync(akademik.NIM);
                var mt = await _db.Matakuliah.FindAsync(akademik.IDMatakuliah);

                akademik.NamaMahasiswa = mh.Nama;
                akademik.NamaMatakuliah = mt.NamaMatakuliah;

                await _db.Akademik.AddAsync(akademik);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
