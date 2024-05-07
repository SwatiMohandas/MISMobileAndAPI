using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Outstanding
{
    public class OutstandingDTO
    {
        public string? ZoneID { get; set; }
        public string? ZoneCode { get; set; }
        public string? DueAmount { get; set; }
        public string? OustStanding { get; set; }
        public string? BranchId { get; set; }
        public string? BranchCode { get; set; }
        public string? RouteID { get; set; }
        public string? RouteName { get; set;}
        public string? CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? ZoneName { get; set; }
        public string? SalesOffice { get;set; }
        public string? BranchName { get; set; }
        public string? CreditLimit { get; set;}
        public string? CreditPeriod { get; set; }
        public string? DueDate { get; set;}
        public string? GreenChannel { get; set;}
        public string? SchemeCustomer { get; set; }
        public string? PaymentMode { get; set; }
        public string? AvgCollectionPeriod { get; set; }
        public string? MappedSA { get;set; }
        public string? RegistrationType { get; set; }
        public string? ChequeReturnCount { get; set; }
        public string? LeaderName { get; set; }
        public string? GOName { get; set; }
        public string? SMName { get; set; }
        public string? VisitedDay { get; set; }
    }
}
