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

        // StreetNumber in type string, to handle usages like '12A'
        [Required]
        public string StreetNumber { get; set; }

        [Required]
        public string Street { get; set; }

        public string Suburb { get; set; }

        [Required]
        public string City { get; set; }

        // Postcode in type string, to handle leading zeros
        [Required, RegularExpression("\\d{4, 10}")]
        public string Postcode { get; set; }

        // Country being the ISO-3166 Alpha-2 country representation
        [Required, StringLength(2)]
        public string Country { get; set; }
    }
}
