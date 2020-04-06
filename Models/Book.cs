using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yellamanchili_Exam02.Models
{
    public class Book
    {
        
        public int BookID { get; set; }
        public string Book_Title { get; set; }
        public string Author_Name { get; set; }
        

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}