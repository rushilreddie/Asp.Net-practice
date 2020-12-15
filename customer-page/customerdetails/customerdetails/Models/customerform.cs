using System;

namespace customerdetails.Models
{
    public class Customerform
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string Address { get; set; }

        public DateTime DateTime { get; set; }

        public string Gender { get; set; }

    }
}
