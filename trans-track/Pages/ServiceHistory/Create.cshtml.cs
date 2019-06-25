using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using trans_track.Data;
using trans_track.Models;

namespace trans_track.Pages.ServiceHistory
{
    public class CreateModel : VehicleNamePageModel
    {
        private readonly trans_track.Data.ApplicationDbContext _context;

        public CreateModel(trans_track.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateVehicleNamesDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Service Service { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyService = new Service();
            if (await TryUpdateModelAsync<Service>(
                emptyService,
                "service",
                s => s.ID, s => s.VehicleID, s => s.ServiceType, s => s.ServiceDate, s => s.ServiceVendor, s => s.Mileage))
            {
                _context.Service.Add(Service);
                await _context.SaveChangesAsync();

                return RedirectToPage("/Vehicles/Index");
            }

            PopulateVehicleNamesDropDownList(_context, emptyService.VehicleID);
            return Page();
        }
    }
}