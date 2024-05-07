using DTO.CategorySales;
using DTO.Login;
using Microsoft.AspNetCore.Mvc;
using Repository.CategorySales;

namespace MobileWebAPI.Controllers.CategorySales
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategorySalesController : Controller
    {
        CategorySalesRepository repository = new CategorySalesRepository();

        /// <summary>
        /// DAILY CATEGORYSALES
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_summary_day(string USERID)
        {
            return repository.catgory_summary_day(USERID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_branch_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_id = arr[1].ToString();

            return repository.catgory_branch_day(u_id, div_id);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_sa_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string b_Id = arr[2].ToString();

            return repository.catgory_sa_day(u_id, b_Id, div_Id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_cus_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sa_id = arr[1].ToString();

            return repository.catgory_cus_day(u_id, sa_id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_product_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string cus_id = arr[1].ToString();

            return repository.catgory_product_day(u_id, cus_id);
        }

        /// <summary>
        /// MOTHLY CATEGORYSALES
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_summary_month(string USERID)
        {
            return repository.catgory_summary_month(USERID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_branch_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_id = arr[1].ToString();

            return repository.catgory_branch_month(u_id, div_id);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_sa_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string b_Id = arr[2].ToString();

            return repository.catgory_sa_month(u_id, b_Id, div_Id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_cus_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sa_id = arr[1].ToString();

            return repository.catgory_cus_month(u_id, sa_id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_product_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string cus_id = arr[1].ToString();

            return repository.catgory_product_month(u_id, cus_id);
        }

        /// <summary>
        /// PERIODICALLY CATEGORYSALE REPORT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_summary_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sdate = arr[1].ToString();
            string edate = arr[2].ToString();
            return repository.catgory_summary_prd(u_id, sdate, edate);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_branch_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_id = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();

            return repository.catgory_branch_prd(u_id, div_id, sdate, edate);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_sa_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div_Id = arr[1].ToString();
            string b_Id = arr[2].ToString();
            string sdate = arr[3].ToString();
            string edate = arr[4].ToString();

            return repository.catgory_sa_prd(u_id, b_Id, div_Id, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_cus_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sa_id = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();

            return repository.catgory_cus_prd(u_id, sa_id, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<CategorySalesDTO>> catgory_product_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string cus_id = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();

            return repository.catgory_product_prd(u_id, cus_id, sdate, edate);
        }
    }
}
