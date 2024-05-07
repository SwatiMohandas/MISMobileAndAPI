using DTO.Admin;
using DTO.Login;
using DTO.Sales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Repository.Sales
{
    public class SalesRepository
    {
        SalesDTO sales = new SalesDTO();
        DataConnection db = new DataConnection();
        SqlConnection myConnection = null;
        IDbService Iservice;
        public SalesRepository(IDbService iservice)
        {
            Iservice = iservice;
        }

        public SalesRepository()
        {
        }

        public List<SalesDTO> sales_catgry_day(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.ZoneID = reader["ZoneID"].ToString();
                    sales.ZoneName = reader["ZoneName"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> sales_branchwise_day_n(string USERID, string ZONEID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_BRANCH_WISE_SUMMARY_DAY_N", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@ZONEID", ZONEID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.BranchId = reader["BranchId"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.ZoneID = reader["ZoneID"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> get_SASale__Daily_soapfood(string USERID, string BRANCHID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_SA_WISE_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@BRANCHID", BRANCHID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.Key = reader["key"].ToString();
                    sales.UserID = reader["UserID"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.DisplayName = reader["DisplayName"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> customer_sale_summary_day(string USERID, string SAUSERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_CUSTOMER_WISE_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@SAUSERID", SAUSERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.CustomerID = reader["CustomerID"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.CustomerName = reader["CustomerName"].ToString();
                    sales.Key = reader["key"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> customer_sale_products_daily(string USERID, string CUSTOMERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_CUSTOMER_PRODUCT_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@CUSTOMERID", CUSTOMERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.Category = reader["Category"].ToString();
                    sales.StockName = reader["StockName"].ToString();
                    sales.Quantity = reader["Quantity"].ToString();
                    sales.NetAmount = reader["NetAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> sales_catgry_month(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.ZoneID = reader["ZoneID"].ToString();
                    sales.ZoneName = reader["ZoneName"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> sales_branchwise_month_n(string USERID, string ZONEID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_BRANCH_WISE_SUMMARY_MONTH_N", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@ZONEID", ZONEID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.BranchId = reader["BranchId"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.ZoneID = reader["ZoneID"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> get_SASale_monthly_soapfood(string USERID, string BRANCHID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_SA_WISE_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@BRANCHID", BRANCHID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.Key = reader["key"].ToString();
                    sales.UserID = reader["UserID"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.DisplayName = reader["DisplayName"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> customer_sale_summary_month(string USERID, string SAUSERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_CUSTOMER_WISE_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@SAUSERID", SAUSERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.CustomerID = reader["CustomerID"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.CustomerName = reader["CustomerName"].ToString();
                    sales.Key = reader["key"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> customer_sale_products_month(string USERID, string CUSTOMERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_CUSTOMER_PRODUCT_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@CUSTOMERID", CUSTOMERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.Category = reader["Category"].ToString();
                    sales.StockName = reader["StockName"].ToString();
                    sales.Quantity = reader["Quantity"].ToString();
                    sales.NetAmount = reader["NetAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> sales_catgry_prd(string u_id, string sdate, string edate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", u_id);
                sqlCmd.Parameters.AddWithValue("@StartDate", sdate);
                sqlCmd.Parameters.AddWithValue("@EndDate", edate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.ZoneID = reader["ZoneID"].ToString();
                    sales.ZoneName = reader["ZoneName"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> sales_branchwise_prd_n(string USERID, string ZONEID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_BRANCH_WISE_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@ZONEID", ZONEID);
                sqlCmd.Parameters.AddWithValue("@StartDate", StartDate);
                sqlCmd.Parameters.AddWithValue("@EndDate", EndDate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.BranchId = reader["BranchId"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.ZoneID = reader["ZoneID"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> get_SASale__prd_soapfood(string USERID, string BRANCHID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_SA_WISE_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@BRANCHID", BRANCHID);
                sqlCmd.Parameters.AddWithValue("@StartDate", StartDate);
                sqlCmd.Parameters.AddWithValue("@EndDate", EndDate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.Key = reader["key"].ToString();
                    sales.UserID = reader["UserID"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.value = reader["value"].ToString();
                    sales.DisplayName = reader["DisplayName"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> customer_sale_summary_prd(string USERID, string SAUSERID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_CUSTOMER_WISE_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@SAUSERID", SAUSERID);
                sqlCmd.Parameters.AddWithValue("@StartDate", StartDate);
                sqlCmd.Parameters.AddWithValue("@EndDate", EndDate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.CustomerID = reader["CustomerID"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.CustomerName = reader["CustomerName"].ToString();
                    sales.Key = reader["key"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<SalesDTO> customer_sale_products_prd(string USERID, string CUSTOMERID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<SalesDTO> SD = new List<SalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALE_CUSTOMER_PRODUCT_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@CUSTOMERID", CUSTOMERID);
                sqlCmd.Parameters.AddWithValue("@StartDate", StartDate);
                sqlCmd.Parameters.AddWithValue("@EndDate", EndDate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.Category = reader["Category"].ToString();
                    sales.StockName = reader["StockName"].ToString();
                    sales.Quantity = reader["Quantity"].ToString();
                    sales.NetAmount = reader["NetAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(sales);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

    }
}
