﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSIMS.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        [Timestamp]
        public DateTime TimeCreated { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
