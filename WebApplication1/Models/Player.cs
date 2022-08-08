using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PlayerClaim
    {       
         public string WrongClaims { get; set; }
         public string ClaimResponses { get; set; }
         public int TicketId { get; set; }
         public DateTime DateClaim { get; set; }
         public DateTime StartDate { get; set; }
         public DateTime EndDate { get; set; }
         public string Player { get; set; }
         public string Agent { get; set; }
         public string Status { get; set; }
    }
}