using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KampusApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KampusApp.Pages.MahasiswaList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Model.Mahasiswa mahasiswa { get; set; }

        public async Task OnGet(int nim)
        {
            mahasiswa = await _db.Mahasiswa.FindAsync(nim);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var MhsFromDB = await _db.Mahasiswa.FindAsync(mahasiswa.NIM);
                MhsFromDB.Nama = mahasiswa.Nama;
                MhsFromDB.Alamat = mahasiswa.Alamat;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
