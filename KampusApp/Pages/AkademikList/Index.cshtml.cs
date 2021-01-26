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
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;

        public IndexModel( ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Akademik> akademik { get; set; }

        public async Task OnGet()
        {
            akademik = await _db.Akademik.ToListAsync();
        }
    }
}
