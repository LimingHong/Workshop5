///Author: Guido Amaya
///Date: April 2019
///Description: this is a class for the "bookingDetails" table data in order to be accesed on the business layer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    public class BookingDetails
    {
        public int BookingDetailId { get; set; }
        public float ItineraryNo { get; set; }
        public DateTime? TripStart { get; set; }
        public DateTime? TripEnd { get; set; }
        public string Description { get; set; }
        public string Destination { get; set; }
        public int BasePrice { get; set; }

    }
}
