using DTO.Sales;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using DTO.CategorySales;

namespace Repository.CategorySales
{
    public class CategorySalesRepository
    {
        CategorySalesDTO sales = new CategorySalesDTO();
        DataConnection db = new DataConnection();
        SqlConnection myConnection = null;

        public List<CategorySalesDTO> catgory_summary_day(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.DivisionID = reader["DivisionID"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.TotalAmount = reader["TotalAmount"].ToString();
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

        public List<CategorySalesDTO> catgory_branch_day(string USERID, string DivisionID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_BRANCHWISE_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.BranchId = reader["BranchId"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.count = reader["count"].ToString();
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

        public List<CategorySalesDTO> catgory_sa_day(string USERID, string BRANCHID, string DivisionID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_SA_WISE_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@BRANCHID", BRANCHID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.UserID = reader["UserID"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.count = reader["count"].ToString();
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

        public List<CategorySalesDTO> catgory_cus_day(string USERID, string SAUSERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_CUSTOMER_WISE_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@SAUSERID", SAUSERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.CustomerID = reader["CustomerID"].ToString();
                    sales.Key = reader["key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.CustomerName = reader["CustomerName"].ToString();
                    
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

        public List<CategorySalesDTO> catgory_product_day(string USERID, string CUSTOMERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_CUSTOMER_PRODUCT_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@CUSTOMERID", CUSTOMERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.Quantity = reader["Quantity"].ToString();
                    sales.Category = reader["Category"].ToString();
                    sales.StockName = reader["StockName"].ToString();
                    sales.TotalAmount = reader["TotalAmount"].ToString();
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

        public List<CategorySalesDTO> catgory_summary_month(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.DivisionID = reader["DivisionID"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.TotalAmount = reader["TotalAmount"].ToString();
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

        public List<CategorySalesDTO> catgory_branch_month(string USERID, string DivisionID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_BRANCHWISE_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.BranchId = reader["BranchId"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.count = reader["count"].ToString();
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

        public List<CategorySalesDTO> catgory_sa_month(string USERID, string BRANCHID, string DivisionID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_SA_WISE_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@BRANCHID", BRANCHID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.UserID = reader["UserID"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.count = reader["count"].ToString();
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

        public List<CategorySalesDTO> catgory_cus_month(string USERID, string SAUSERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_CUSTOMER_WISE_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@SAUSERID", SAUSERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.CustomerID = reader["CustomerID"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.CustomerName = reader["CustomerName"].ToString();

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

        public List<CategorySalesDTO> catgory_product_month(string USERID, string CUSTOMERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_CUSTOMER_PRODUCT_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@CUSTOMERID", CUSTOMERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.Quantity = reader["Quantity"].ToString();
                    sales.Category = reader["Category"].ToString();
                    sales.StockName = reader["StockName"].ToString();
                    sales.TotalAmount = reader["TotalAmount"].ToString();
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

        public List<CategorySalesDTO> catgory_summary_prd(string USERID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@StartDate", StartDate);
                sqlCmd.Parameters.AddWithValue("@EndDate", EndDate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.DivisionID = reader["DivisionID"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.TotalAmount = reader["TotalAmount"].ToString();
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

        public List<CategorySalesDTO> catgory_branch_prd(string USERID, string DivisionID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_BRANCHWISE_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
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
                    sales.count = reader["count"].ToString();
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

        public List<CategorySalesDTO> catgory_sa_prd(string USERID, string BRANCHID, string DivisionID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_SA_WISE_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@BRANCHID", BRANCHID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@StartDate", StartDate);
                sqlCmd.Parameters.AddWithValue("@EndDate", EndDate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    sales.UserID = reader["UserID"].ToString();
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.count = reader["count"].ToString();
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

        public List<CategorySalesDTO> catgory_cus_prd(string USERID, string SAUSERID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_CUSTOMER_WISE_SUMMARY_PERIOD", myConnection);
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
                    sales.Key = reader["Key"].ToString();
                    sales.SoapSale = reader["SoapSale"].ToString();
                    sales.FoodSale = reader["FoodSale"].ToString();
                    sales.CustomerName = reader["CustomerName"].ToString();

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

        public List<CategorySalesDTO> catgory_product_prd(string USERID, string CUSTOMERID, string StartDate, string EndDate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<CategorySalesDTO> SD = new List<CategorySalesDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_CUSTOMER_PRODUCT_SUMMARY_MONTH", myConnection);
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
                    sales.Quantity = reader["Quantity"].ToString();
                    sales.Category = reader["Category"].ToString();
                    sales.StockName = reader["StockName"].ToString();
                    sales.TotalAmount = reader["TotalAmount"].ToString();
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
