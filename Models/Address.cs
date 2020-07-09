using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSIMS.Models
{
    public class Address
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int StreetNumber { get; set; }

        [Required]
        public string Street { get; set; }

        public string Suburb { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int Postcode { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
