using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dating.Service
{
    public class MatchingService
    {
        public bool IsHopMenh(int m1, int m2)
        {
            return (Math.Abs(m1 - m2) == 1 || Math.Abs(m1 - m2) == 4);
        }
    }
}