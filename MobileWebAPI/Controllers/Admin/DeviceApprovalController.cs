using Microsoft.AspNetCore.Mvc;
using DTO.Admin;
using Repository.Admin;

namespace MobileWebAPI.Controllers.Admin
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]/[action]")]
    [ApiController]
    public class DeviceApprovalController : Controller
    {
        DeviceApprovalDTO approvalDTO = new DeviceApprovalDTO();
        DeviceApprovalRepository repository = new DeviceApprovalRepository();


        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<DeviceApprovalDTO>> Device_Approval()
        {
            return repository.Device_Approval();
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<DeviceApprovalDTO>> Device_Approving(string DeviceID)
        {
            return repository.Device_Approving(DeviceID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<DeviceApprovalDTO>> Device_Rejecting(string DeviceID)
        {
            return repository.Device_Rejecting(DeviceID);
        }
    }
}
