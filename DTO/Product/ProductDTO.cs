using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Product
{
    public class ProductDTO
    {
        public ProductDTO() { }
        public string? FoodSale { get; set; }
        public string? SoapSale { get; set; }
        public string? Key { get; set; }
        public string? DivisionID { get; set; }
        public string? TotalAmount { get; set;}
        public string? CategoryID { get; set; }
        public string? ProductMasterId { get; set; }
        public string? Box { get; set; }
        public string? ProductName { get; set; }
        public string? StockID { get; set; }
        public string? VarientName { get; set; }
        public string? SaleAmount { get; set; }
        public string? CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? Quantity { get; set; }
    }
}
