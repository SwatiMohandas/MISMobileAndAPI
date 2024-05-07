using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Admin
{
    public class DeviceApprovalDTO
    {
        public DeviceApprovalDTO() { }
        public string? DeviceID { get; set; }
        public string? UserName { get; set; }
        public string? DeviceIME { get; set; }
        public string? LoginDate { get; set; }
        public string? EmployeeType { get; set; }
        public string? Branch { get; set; }
    }
}
