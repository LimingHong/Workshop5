///Author: Guido Amaya
///Date: April 2019
///Description: this is the Customer History data class, which will gives to the business layer
/// the main elements in order to complete the functionality required

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    public class CustomerHistory
    {
        public string CustFirstName { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Destination { get; set; }
        public int BasePrice { get; set; }

    }
}
