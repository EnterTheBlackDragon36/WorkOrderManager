using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrderManager.Classes
{
    public class Company
    {
        private int id { get; set; }
        private string companyName { get; set; }
        private string companyPhone { get; set; }
        private string companyFax { get; set; }
        private string companyWebSite { get; set; }
        private Address companyAddress { get; set; }
        private Contact companyEmployee { get; set; }
        private List<WorkOrder> companyWorkOrders = new List<WorkOrder>();
        internal string companyWebAddress;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string CompanyPhone
        {
            get { return companyPhone; }
            set { companyPhone = value; }
        }

        public string CompanyFax
        {
            get { return companyFax; }
            set { companyFax = value; }
        }

        public string CompanyWebSite
        {
            get { return companyWebSite; }
            set { companyWebSite = value; }
        }

        public Address CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }

        public Contact ComapnyContact
        {
            get { return companyEmployee; }
            set { companyEmployee = value; }
        }
       
    }
}
