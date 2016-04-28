using AmbulanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.ViewModels
{
    public class AmbulanceCreateViewModel
    {
        [Required, Display(Name ="Ambulance Code")]
        public long AmbulanceCode { get; set; }
        [Required, MaxLength(10)]
        public string Plate { get; set; }
        [Display(Name = "Ambulance Type")]
        public AmbulanceType AmbulanceType { get; set; }
        [Display(Name = "Ambulance State")]
        public AmbulanceState AmbulanceState { get; set; }
    }
}
