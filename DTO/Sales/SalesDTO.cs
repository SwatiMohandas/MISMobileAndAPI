using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Sales
{
    public class SalesDTO
    {
        public SalesDTO() { }
        public string? ZoneID { get; set; }
        public string? ZoneName { get; set; }
        public string? value { get; set; }
        public string? FoodSale { get; set; }
        public string? SoapSale { get; set;}
        public string? BranchId { get; set; }
        public string? Key { get; set; }
        public string? UserID { get; set; }
        public string? DisplayName { get; set; }
        public string? CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? Category { get; set; }
        public string? StockName { get; set; }
        public string? Quantity { get; set;}
        public string? NetAmount { get; set;}

    }
}
