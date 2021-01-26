using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KampusApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KampusApp.Pages.MatakuliahList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Matakuliah matakuliah { get; set; }

        public async Task OnGet(int id)
        {
            matakuliah = await _db.Matakuliah.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var mtk = await _db.Matakuliah.FindAsync(matakuliah.IDMatakuliah);
                mtk.NamaMatakuliah = matakuliah.NamaMatakuliah;
                mtk.SKS = matakuliah.SKS;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();

        }
    }
}
