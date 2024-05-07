using DTO.Outstanding;
using Microsoft.AspNetCore.Mvc;
using Repository.Outstanding;

namespace MobileWebAPI.Controllers.Outstanding
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OutstandingController : Controller
    {
        OutstandingRepository repository = new OutstandingRepository();

        /// <summary>
        /// DAILY OUTSTANDING
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<OutstandingDTO>> get_OutstandingSummary(string USERID)
        {
            return repository.get_OutstandingSummary(USERID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<OutstandingDTO>> get_BranchWise_OutstandingSummary(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string zn_id = arr[1].ToString();

            return repository.get_BranchWise_OutstandingSummary(u_id, zn_id);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<OutstandingDTO>> get_BranchRout_OutstandingSummary(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string b_id = arr[1].ToString();

            return repository.get_BranchRout_OutstandingSummary(u_id, b_id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<OutstandingDTO>> get_Customer_OutstandingSummary(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string r_Id = arr[1].ToString();

            return repository.get_Customer_OutstandingSummary(u_id, r_Id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<OutstandingDTO>> get_Customer(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string cus_id = arr[1].ToString();

            return repository.get_Customer(u_id, cus_id);
        }

    } 
}
