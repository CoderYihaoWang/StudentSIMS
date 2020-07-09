using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSIMS.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        [Required]
        public int StudentId { get; set; }

        public Student Student { get; set; }

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
