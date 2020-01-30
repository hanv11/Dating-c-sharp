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
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        public AccountTypes AccountType { get; set; }
        public string description { get; set; }
        public string Images { get; set; }
        public string Address { get; set; }
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