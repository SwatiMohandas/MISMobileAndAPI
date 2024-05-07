using DTO.Product;
using DTO.Sales;
using Microsoft.AspNetCore.Mvc;
using Repository.Product;

namespace MobileWebAPI.Controllers.Product
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        ProductRepository repository = new ProductRepository();

        /// <summary>
        /// DAILY PRODUCT
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> catgory_summary_day(string USERID)
        {
            return repository.catgory_summary_day(USERID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_Daily_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();

            return repository.get_product_Daily_ctgry(u_id, div);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_Vdaily_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();
            string pId = arr[2].ToString();
            string cat = arr[3].ToString();

            return repository.get_product_Vdaily_ctgry(u_id, div,pId,cat);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_V_cus_daily_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();
            string stId = arr[2].ToString();

            return repository.get_product_V_cus_daily_ctgry(u_id, div,stId);
        }

        /// <summary>
        /// MOTHLY PRODUCT
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> catgory_summary_month(string USERID)
        {
            return repository.catgory_summary_month(USERID);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_monthly_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();

            return repository.get_product_monthly_ctgry(u_id, div);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_Vmonthly_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();
            string pId = arr[2].ToString();
            string cat = arr[3].ToString();

            return repository.get_product_Vmonthly_ctgry(u_id, div, pId, cat);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_V_cus_monthly_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();
            string stId = arr[2].ToString();

            return repository.get_product_V_cus_monthly_ctgry(u_id, div, stId);
        }

        /// <summary>
        /// PERIODICALLY PRODUCT REPORT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> catgory_summary_prd(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string sdate = arr[1].ToString();
            string edate = arr[2].ToString();
            return repository.catgory_summary_prd(u_id, sdate, edate);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_prd_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();
            string sdate = arr[2].ToString();
            string edate = arr[3].ToString();

            return repository.get_product_prd_ctgry(u_id, div, sdate, edate);
        }

        [HttpGet]

        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_Vprd_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();
            string pId = arr[2].ToString();
            string cat = arr[3].ToString();
            string sdate = arr[4].ToString();
            string edate = arr[5].ToString();

            return repository.get_product_Vprd_ctgry(u_id, div, pId, cat, sdate, edate);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<ProductDTO>> get_product_V_cus_period_ctgry(string id)
        {
            string[] arr = id.Split('@');
            string u_id = arr[0].ToString();
            string div = arr[1].ToString();
            string stId = arr[2].ToString();
            string sdate = arr[3].ToString();
            string edate = arr[4].ToString();

            return repository.get_product_V_cus_period_ctgry(u_id, div, stId, sdate, edate);
        }

    }
}
