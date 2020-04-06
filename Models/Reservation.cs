using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yellamanchili_Exam02.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }

        public DateTime Date_received { get; set; }
        public int BookID { get; set; }
        public int BorrowerID { get; set; }
        

        public virtual Book Book { get; set; }
        public virtual Borrower Borrower { get; set; }
    }
}