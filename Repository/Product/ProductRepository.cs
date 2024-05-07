using DTO.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Repository.Product
{
    public class ProductRepository
    {
        ProductDTO product = new ProductDTO();
        DataConnection db = new DataConnection();
        SqlConnection myConnection = null;

        public List<ProductDTO> catgory_summary_day(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
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
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.Key = reader["Key"].ToString();
                    product.SoapSale = reader["SoapSale"].ToString();
                    product.FoodSale = reader["FoodSale"].ToString();
                    product.TotalAmount = reader["TotalAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_Daily_ctgry(string USERID, string DIVISIONID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_PRODUCT_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@ProductMasterID", 0);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.CategoryID = reader["CategoryID"].ToString();
                    product.ProductMasterId = reader["ProductMasterId"].ToString();
                    product.ProductName = reader["ProductName"].ToString();
                    product.Box = reader["Box"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_Vdaily_ctgry(string USERID, string DIVISIONID, string ProductMasterID, string CategoryID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_PRODUCT_VARIENT_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@ProductMasterID", ProductMasterID);
                sqlCmd.Parameters.AddWithValue("@CategoryID", CategoryID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.StockID = reader["StockID"].ToString();
                    product.VarientName = reader["VarientName"].ToString();
                    product.Box = reader["Box"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_V_cus_daily_ctgry(string USERID, string DIVISIONID, string StockID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_PRODUCT_VARIENT_DAY_CUSTOMER_LIST", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@StockID", StockID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.CustomerID = reader["CustomerID"].ToString();
                    product.Quantity = reader["Quantity"].ToString();
                    product.CustomerName = reader["CustomerName"].ToString();
                    product.SaleAmount = reader["SaleAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> catgory_summary_month(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
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
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.Key = reader["Key"].ToString();
                    product.SoapSale = reader["SoapSale"].ToString();
                    product.FoodSale = reader["FoodSale"].ToString();
                    product.TotalAmount = reader["TotalAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_monthly_ctgry(string USERID, string DIVISIONID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_PRODUCT_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@ProductMasterID", 0);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.CategoryID = reader["CategoryID"].ToString();
                    product.ProductMasterId = reader["ProductMasterId"].ToString();
                    product.ProductName = reader["ProductName"].ToString();
                    product.Box = reader["Box"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_Vmonthly_ctgry(string USERID, string DIVISIONID, string ProductMasterID, string CategoryID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_PRODUCT_VARIENT_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@ProductMasterID", ProductMasterID);
                sqlCmd.Parameters.AddWithValue("@CategoryID", CategoryID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.StockID = reader["StockID"].ToString();
                    product.VarientName = reader["VarientName"].ToString();
                    product.Box = reader["Box"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_V_cus_monthly_ctgry(string USERID, string DIVISIONID, string StockID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_PRODUCT_VARIENT_MONTH_CUSTOMER_LIST", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@StockID", StockID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.CustomerID = reader["CustomerID"].ToString();
                    product.Quantity = reader["Quantity"].ToString();
                    product.CustomerName = reader["CustomerName"].ToString();
                    product.SaleAmount = reader["SaleAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> catgory_summary_prd(string USERID, string sdate, string edate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@StartDate", sdate);
                sqlCmd.Parameters.AddWithValue("@EndDate", edate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.Key = reader["Key"].ToString();
                    product.SoapSale = reader["SoapSale"].ToString();
                    product.FoodSale = reader["FoodSale"].ToString();
                    product.TotalAmount = reader["TotalAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_prd_ctgry(string USERID, string DIVISIONID, string sdate, string edate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_PRODUCT_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@ProductMasterID", 0);
                sqlCmd.Parameters.AddWithValue("@StartDate", sdate);
                sqlCmd.Parameters.AddWithValue("@EndDate", edate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.CategoryID = reader["CategoryID"].ToString();
                    product.ProductMasterId = reader["ProductMasterId"].ToString();
                    product.ProductName = reader["ProductName"].ToString();
                    product.Box = reader["Box"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_Vprd_ctgry(string USERID, string DIVISIONID, string ProductMasterID, string CategoryID, string sdate, string edate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_CATEGORY_PRODUCT_VARIENT_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@ProductMasterID", ProductMasterID);
                sqlCmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                sqlCmd.Parameters.AddWithValue("@StartDate", sdate);
                sqlCmd.Parameters.AddWithValue("@EndDate", edate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.DivisionID = reader["DivisionID"].ToString();
                    product.StockID = reader["StockID"].ToString();
                    product.VarientName = reader["VarientName"].ToString();
                    product.Box = reader["Box"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<ProductDTO> get_product_V_cus_period_ctgry(string USERID, string DIVISIONID, string StockID, string sdate, string edate)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<ProductDTO> SD = new List<ProductDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_PRODUCT_VARIENT_PERIOD_CUSTOMER_LIST", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DIVISIONID", DIVISIONID);
                sqlCmd.Parameters.AddWithValue("@StockID", StockID);
                sqlCmd.Parameters.AddWithValue("@StartDate", sdate);
                sqlCmd.Parameters.AddWithValue("@EndDate", edate);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    product.CustomerID = reader["CustomerID"].ToString();
                    product.Quantity = reader["Quantity"].ToString();
                    product.CustomerName = reader["CustomerName"].ToString();
                    product.SaleAmount = reader["SaleAmount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(product);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }
    }
}
