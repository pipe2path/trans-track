using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace trans_track.Pages.ServiceHistory
{
    public class SelectListPageModel : PageModel
    {
        public SelectList ServiceTypeSL { get; set; }
        public SelectList VehicleNameSL { get; set; }

        public void PopulateVehicleNamesDropDownList(trans_track.Data.ApplicationDbContext _context,
            object selectedVehicle = null)
        {
            var vehiclesQuery = from v in _context.Vehicle
                                orderby v.Make
                                select v;

            VehicleNameSL = new SelectList(vehiclesQuery.AsNoTracking(), "ID", "VehicleName", selectedVehicle);

        }

        public void PopulateServiceTypeDropDownList(trans_track.Data.ApplicationDbContext _context,
             object selectedServiceType = null)
        {
            var serviceTypeQuery = from t in _context.ServiceType
                                   orderby t.Name
                                   select t;

            ServiceTypeSL = new SelectList(serviceTypeQuery.AsNoTracking(), "ID", "Name", selectedServiceType);

        }
    }
}
