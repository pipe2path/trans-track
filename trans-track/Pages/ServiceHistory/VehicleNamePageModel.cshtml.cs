using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace trans_track.Pages.ServiceHistory
{
    public class VehicleNamePageModel : PageModel
    {
        public SelectList VehicleNameSL { get; set; }

        public void PopulateVehicleNamesDropDownList(trans_track.Data.ApplicationDbContext _context,
            object selectedVehicle = null)
        {
            var vehiclesQuery = from v in _context.Vehicle
                                orderby v.Make
                                select v;

            VehicleNameSL = new SelectList(vehiclesQuery.AsNoTracking(), "ID", "VehicleName", selectedVehicle);

        }
    }
}
