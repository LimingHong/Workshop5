﻿using System;
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
