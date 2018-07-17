using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrderManager.Classes
{
    public class WorkOrder
    {
        //New Work Order
        private int id { get; set; }
        private string workOrderCompany { get; set; }
        private string workOrderNumber { get; set; }
        private DateTime workOrderDate { get; set; }
        private DateTime workOrderOpened { get; set; }
        private DateTime workOrderClosed { get; set; }
        private DateTime workOrderDuration { get; set; }
        private string requestedBy { get; set; }
        private string department { get; set; }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string WorkOrderCompany
        {
            get { return workOrderCompany; }
            set { workOrderCompany = value; }
        }

        public string WorkOrderNumber
        {
            get { return workOrderNumber; }
            set { workOrderNumber = value; }
        }

        public DateTime WorkOrderDate
        {
            get { return workOrderDate; }
            set { workOrderDate = value; }
        }

        public string RequestedBy
        {
            get { return requestedBy; }
            set { requestedBy = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
            


     
        //Work Order Address Location - Can be imported from Company Address Details
        public class WorkOrderAddressLocation
        {
            private Address workOrderAddress { get; set; }

            public Address WorkOrderAddress
            {
                get { return workOrderAddress; }
                set { workOrderAddress = value; }
            }
        }

        //Work Order Company Contact Information
        public class WorkOrderCompanyContact
        {
            private string workOrderCompanyPhone { get; set; }
            private string workOrderCompanyFax { get; set; }
            private string workOrderCompanyWebSite { get; set; }

            public string WorkOrderCompanyPhone
            {
                get { return workOrderCompanyPhone; }
                set { workOrderCompanyPhone = value; }
            }

            public string WorkOrderCompanyFax
            {
                get { return workOrderCompanyFax; }
                set { workOrderCompanyFax = value; }
            }

            public string WorkOrderCompanyWebSite
            {
                get { return workOrderCompanyWebSite; }
                set { workOrderCompanyWebSite = value; }
            }
        }

        //work order job description
        public class WorkOrderJobDescription
        {
            private string workOrderJob { get; set; }
            private string workOrderAdditionalDetails { get; set; }

            public string WorkOrderJob
            {
                get { return workOrderJob; }
                set { workOrderJob = value; }
            }

            public string WorkOrderAdditionalDetails
            {
                get { return workOrderAdditionalDetails; }
                set { workOrderAdditionalDetails = value; }
            }
        }

        //Work Order Bill To Information
        public class WorkOrderBilling
        {
            private string workOrderBillToName { get; set; }
            private string workOrderBillToCompany { get; set; }
            private Address workOrderBillTo { get; set; }

            public string WorkOrderBillToName
            {
                get { return workOrderBillToName; }
                set { workOrderBillToName = value; }
            }

            public string WorkOrderBillToCompany
            {
                get { return workOrderBillToCompany; }
                set { workOrderBillToCompany = value; }
            }

            public Address WorkOrderBillTo
            {
                get { return workOrderBillTo; }
                set { workOrderBillTo = value; }
            }
        }

        //Work Order Ship To Information *If Applicable*
        public class WorkOrderShipping
        {
            private string workOrderShipToName { get; set; }
            private string workOrderShipToCompany { get; set; }
            private Address workOrderShipTo { get; set; }

            public string WorkOrderShipToName
            {
                get { return workOrderShipToName; }
                set { workOrderShipToName = value; }
            }

            public string WorkOrderShipToCompany
            {
                get { return workOrderShipToCompany; }
                set { workOrderShipToCompany = value; }
            }

            public Address WorkOrderShipTo
            {
                get { return workOrderShipTo; }
                set { workOrderShipTo = value; }
            }
        }

        //Work Order Line Item Billing Details
        public class WorkOrderLineItem
        {
            private int workOrderLineItemQuantity { get; set; }
            private string workOrderLineItemDescription { get; set; }
            private double workOrderLineItemUnitPrice { get; set; }
            private double workOrderLineItemLineTotal { get; set; }
         

            public int WorkOrderLineItemQuantity
            {
                get { return workOrderLineItemQuantity; }
                set { workOrderLineItemQuantity = value; }
            }

            public string WorkOrderLineItemDescription
            {
                get { return workOrderLineItemDescription; }
                set { workOrderLineItemDescription = value; }
            }

            public double WorkOrderLineItemUnitPrice
            {
                get { return workOrderLineItemUnitPrice; }
                set { workOrderLineItemUnitPrice = value; }
            }

            public double WorkOrderLineItemTotal
            {
                get { return WorkOrderLineItemTotal = workOrderLineItemQuantity * workOrderLineItemUnitPrice; }
                set { WorkOrderLineItemTotal = value; }
            }
        }

        //Work Order Current Status
        public enum workOrderStatus
        {
            Opened = 0,
            Closed = 1
        }

      
    }
}
