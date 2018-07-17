using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrderManager.Classes
{
    public class Contact
    {
        private int id { get; set; }
        private string fullName { get; set; }
        private string phone { get; set; }
        private string email { get; set; }
        private string work { get; set; }
        private string jobTitle { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Work
        {
            get { return work; }
            set { work = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

    }
}
