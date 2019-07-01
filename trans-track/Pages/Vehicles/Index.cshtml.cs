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
using trans_track.Pages.Vehicles;

namespace trans_track.Pages.Vehicles
{
    [Authorize]
    public class IndexModel : VehicleViewModel
    {
        private readonly trans_track.Data.ApplicationDbContext _context;

        public IndexModel(trans_track.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<trans_track.Models.Vehicle> Vehicles { get;set; }
        public IList<trans_track.Pages.Vehicles.VehicleViewModel> VehicleVM { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Vehicles = await _context.Vehicle
                               .Include(v => v.Services)
                                .AsNoTracking().ToListAsync();

            List<VehicleViewModel> vehicles = new List<VehicleViewModel>();
            foreach (trans_track.Models.Vehicle v in Vehicles)
            {
                trans_track.Pages.Vehicles.VehicleViewModel vehicle = new Vehicles.VehicleViewModel();
                vehicle.ID = v.ID;
                vehicle.Make = v.Make;
                vehicle.Model = v.Model;
                vehicle.Year = v.Year;
                vehicle.License = v.License;
                vehicle.Capacity = v.Capacity;
                vehicle.VIN = v.VIN;
                vehicle.PricePaid = v.PricePaid;
                vehicle.PurchasedFrom = v.PurchasedFrom;
                vehicle.DatePurchased = v.DatePurchased;

                var rules = await _context.Rule
                                .AsNoTracking().ToListAsync();

                var serviceTypeRules = await _context.WarningRule
                                        .AsNoTracking().ToListAsync();

                var result = from d in v.Services
                             group d by d.ServiceTypeID into g
                             select new { ServiceTypeID = g.Key, MaxServiceDate = g.Max(s => s.ServiceDate) };

                vehicle.Warning = false;
                vehicle.WarningMessage = "";
                foreach (var r in result)
                {
                    switch (r.ServiceTypeID)
                    {
                        case 1:
                            if (DateTime.Today > r.MaxServiceDate.AddDays(90))
                            {
                                vehicle.Warning = true;
                                vehicle.WarningMessage += "Oil Change 3 month alert\\n" ;
                            }
                            break;
                        case 3:
                            if (DateTime.Today > r.MaxServiceDate.AddDays(180))
                            {
                                vehicle.Warning = true;
                                vehicle.WarningMessage += "Transmission Fluid Flush 6 month alert\\n";
                            }
                            break;
                    }
                }
                vehicles.Add(vehicle);
            }
            VehicleVM = vehicles;

            return Page();

        }
    }
}
