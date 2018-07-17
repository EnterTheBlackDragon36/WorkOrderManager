using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrderManager.Classes
{
    public class Address
    {
        private string streetAddress { get; set; }
        private string address2 { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string zipCode { get; set; }

       
        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
      
    }
}
