using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assign_02_V2.Models {
    public class User : IdentityUser {
        public User() : base() {  }

        public User(string userName,
                string email,
                long mobileNumber,
                string password,
                string firstName,
                string lastName,
                string street,
                string city,
                string province,
                string postalCode,
                string country) : base() {

            UserName = userName;
            Email = email;
            MobileNumber = mobileNumber;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            City = city;
            Province = province;
            PostalCode = postalCode;
            Country = country;
        }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override string UserName { get; set; }

        public long MobileNumber { get; set; }

        [MinLength(6)]
        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        [MinLength(4)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string Province { get; set; }

        [StringLength(6)]
        public string PostalCode { get; set; }

        [Required]
        [MinLength(3)]
        public string Country { get; set; }

        public bool IsAdmin { get; set; }

    }

}
