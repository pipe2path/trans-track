using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using trans_track.Data;
using trans_track.Models;

namespace trans_track.Pages.Vehicle
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly trans_track.Data.ApplicationDbContext _context;

        public IndexModel(trans_track.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<trans_track.Models.Vehicle> Vehicle { get;set; }

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicle.ToListAsync();
        }
    }
}
