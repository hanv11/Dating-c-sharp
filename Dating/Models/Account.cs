using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Dating.Models
{
    public class Account: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int TuoiAmLich { get; set; }
        public int Menh { get; set; }
        public GenderType Gender { get; set; }
        public AccountTypes AccountType { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserStatus Status { get; set; }

        public enum UserStatus
        {
            Active = 1,
            DeActive = 2,
            Delete = 0
        }

        public enum AccountTypes
        {
            Copper = 0,
            Silver = 1,
            Gold = 2,
            Platium = 3
        }
        
        public enum GenderType
        {
            Male = 1,
            Female = 0,
            Others = 2
        }
    }
}