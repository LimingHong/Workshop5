///Author: Guido Amaya
///Date: April 2019
///Description: this is a class for the "Bookings" table data in order to be accesed on the business layer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
   public class Bookings
    {
        public int BookingId { get; set; }
        public DateTime? BookingDate { get; set; }
        public string BookingNo { get; set; }
        public float TravelerCount { get; set; }

    }
}
