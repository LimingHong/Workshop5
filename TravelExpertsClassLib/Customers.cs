using System.ComponentModel.DataAnnotations;

namespace TravelExpertsClassLib
{
    public class Customers
    {
        public Customers()
        { }

        public int CustomerId { get; set; }

        [Required]
        public string CustFirstName { get; set; }

        [Required]
        public string CustLastName { get; set; }

        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustProv { get; set; }


        public string CustPostal { get; set; }
        public string CustHomePhone { get; set; }
        public string CustBusPhone { get; set; }
        public string CustEmail { get; set; }
        public int? AgentId { get; set; }
        public string username { get; set; }
        public string userPass { get; set; }
    }
}
