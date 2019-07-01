using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace trans_track.Models
{
    public class Service
    {
        public int ID { get; set; }
        public int VehicleID { get; set; }

        [Display(Name = "Service Type")]
        public int ServiceTypeID { get; set; }

        [Display(Name="Service Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime ServiceDate { get; set; }

        [Display(Name = "Repaired At")]
        public string ServiceVendor { get; set; }
        
        [RegularExpression(@"^[0-9]+$")]
        public int Mileage { get; set; }

        public Vehicle Vehicle { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
