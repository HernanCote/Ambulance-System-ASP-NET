using AmbulanceSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.ViewModels
{
    public class CreateIpsViewModel
    {
        [Required, MaxLength(40),Display(Name="IPS Name")]
        public string Name { get; set; }
        [Required, MaxLength(40), Display(Name = "IPS Type")]
        public string Type { get; set; }
        [Display(Name="Direction of the IPS")]
        public Direction Direction { get; set; }
    }
}
