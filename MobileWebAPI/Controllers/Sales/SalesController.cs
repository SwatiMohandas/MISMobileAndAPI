using DTO.Sales;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Sales;

namespace MobileWebAPI.Controllers.Sales
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SalesController : Controller
    {
        IDbService Iservice;

        SalesRepository repository = new SalesRepository();


        /// <summary>
        /// DAILY SALES
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> sales_catgry_day(string USERID)
        {
            return repository.sales_catgry_day(USERID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> sales_branchwise_day_n(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string zn_id = arr[1].ToString();

            return repository.sales_branchwise_day_n(u_id, zn_id);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> get_SASale__Daily_soapfood(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string b_id = arr[1].ToString();

            return repository.get_SASale__Daily_soapfood(u_id, b_id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> customer_sale_summary_day(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sa_id = arr[1].ToString();

            return repository.customer_sale_summary_day(u_id, sa_id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> customer_sale_products_daily(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string cus_id = arr[1].ToString();

            return repository.customer_sale_products_daily(u_id, cus_id);
        }

        /// <summary>
        /// MOTHLY SALES
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> sales_catgry_month(string USERID)
        {
            return repository.sales_catgry_month(USERID);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> sales_branchwise_month_n(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string zn_id = arr[1].ToString();
            return repository.sales_branchwise_month_n(u_id, zn_id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> get_SASale_monthly_soapfood(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string b_id = arr[1].ToString();

            return repository.get_SASale_monthly_soapfood(u_id, b_id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> customer_sale_summary_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sa_id = arr[1].ToString();

            return repository.customer_sale_summary_month(u_id, sa_id);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> customer_sale_products_month(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string cus_id = arr[1].ToString();

            return repository.customer_sale_products_month(u_id, cus_id);
        }

        /// <summary>
        /// PERIODICALLY SALE REPORT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> sales_catgry_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sdate = arr[1].ToString();
            string edate = arr[2].ToString();
            return repository.sales_catgry_prd(u_id, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> sales_branchwise_prd_n(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string zn_id = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();
            return repository.sales_branchwise_prd_n(u_id, zn_id, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> get_SASale__prd_soapfood(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string b_id = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();

            return repository.get_SASale__prd_soapfood(u_id, b_id, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> customer_sale_summary_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sa_id = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();

            return repository.customer_sale_summary_prd(u_id, sa_id, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<SalesDTO>> customer_sale_products_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string cus_id = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();

            return repository.customer_sale_products_prd(u_id, cus_id, sdate, edate);
        }


    }
}
