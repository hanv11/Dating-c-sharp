using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dating.Models
{
    public class DatingInfo
    {
        public string AccountId { get; set; }
        public string GenderLike { get; set; }
        public string AddressDating { get; set; }
        public int HowFar { get; set; }
        public string Liked { get; set; }
    }
}