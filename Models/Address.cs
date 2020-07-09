using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSIMS.Models
{
    public class Address
    {
        public int StudentId { get; set; }

        public int StreetNumber { get; set; }

        public string Street { get; set; }

        public string Suberb { get; set; }

        public string City { get; set; }

        public int Postcode { get; set; }

        public string Country { get; set; }
    }
}
