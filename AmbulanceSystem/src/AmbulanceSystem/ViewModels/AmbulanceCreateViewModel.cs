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
        [Required, Display(Name ="Code")]
        public long AmbulanceCode { get; set; }
        [Required, MaxLength(10)]
        public string Plate { get; set; }
        [Required]
        public AmbulanceType AmbulanceType { get; set; }
        public AmbulanceState AmbulanceState { get; set; }
    }
}
