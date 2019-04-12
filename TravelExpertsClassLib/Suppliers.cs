///Author: Guido Amaya
///Date: April 2019
///Description: this is a class for the "suppliers" table data in order to be accesed on the business layer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    public class Suppliers
    {
        public long SupplierId { get; set; }
        public string SupName { get; set; }
    }
}
