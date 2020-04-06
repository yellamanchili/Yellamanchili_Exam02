using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Yellamanchili_Exam02.Models
{
    public class Borrower
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
    
        public int BorrowerID { get; set; }
        public string status { get; set; }
        public string Borrower_name { get; set; }
        

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}