using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign_02_V2.Models {
    public class AppRole : IdentityRole {

        public AppRole() : base(){ }

        public AppRole(string roleName) : base(roleName) {
        }

        public AppRole(string roleName, string description, DateTime creationDate) : base(roleName) {
            Description = description;
            CreationDate = creationDate;
        }

        //public override string Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
