using DTO.PrimeSale;
using Microsoft.AspNetCore.Mvc;
using Repository.PrimeSale;

namespace MobileWebAPI.Controllers.PrimeSale
{
    public class PrimeSaleController : Controller
    {
        PrimeSaleRepository repository = new PrimeSaleRepository();

        /// <summary>
        /// DAILY PRIME SALES
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_summary_day(string USERID)
        {
            return repository.prime_summary_day(USERID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_sm_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();

            return repository.prime_sm_day(u_id, div_Id);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();

            return repository.prime_leader_day(u_id, div_Id, sm_Id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_go_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();
            string lid = arr[3].ToString();

            return repository.prime_leader_go_day(u_id, div_Id, sm_Id, lid);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_go_CUSTOMER_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();
            string lid = arr[3].ToString();
            string gid = arr[4].ToString();

            return repository.prime_leader_go_CUSTOMER_day(u_id, div_Id, sm_Id, lid, gid);
        }

        /// <summary>
        /// MONTHLY PRIME SALES
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_summary_month(string USERID)
        {
            return repository.prime_summary_month(USERID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_sm_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();

            return repository.prime_sm_month(u_id, div_Id);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();

            return repository.prime_leader_month(u_id, div_Id, sm_Id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_go_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();
            string lid = arr[3].ToString();

            return repository.prime_leader_go_month(u_id, div_Id, sm_Id, lid);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_go_CUSTOMER_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();
            string lid = arr[3].ToString();
            string gid = arr[4].ToString();

            return repository.prime_leader_go_CUSTOMER_month(u_id, div_Id, sm_Id, lid, gid);
        }

        /// <summary>
        /// PERIODICALLY PRIME SALES
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_summary_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sdate = arr[1].ToString();
            string edate = arr[2].ToString();
            return repository.prime_summary_prd(u_id, sdate, edate);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_sm_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();

            return repository.prime_sm_prd(u_id, div_Id, sdate, edate);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();
            string sdate = arr[3].ToString();
            string edate = arr[4].ToString();

            return repository.prime_leader_prd(u_id, div_Id, sm_Id, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_go_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();
            string lid = arr[3].ToString();
            string sdate = arr[4].ToString();
            string edate = arr[5].ToString();

            return repository.prime_leader_go_prd(u_id, div_Id, sm_Id, lid, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<PrimeSaleDTO>> prime_leader_CUSTOMER_go_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string sm_Id = arr[2].ToString();
            string lid = arr[3].ToString();
            string gid = arr[4].ToString();
            string sdate = arr[5].ToString();
            string edate = arr[6].ToString();

            return repository.prime_leader_CUSTOMER_go_prd(u_id, div_Id, sm_Id, lid, gid, sdate, edate);
        }
    }
}
