using DTO.Outstanding;
using DTO.Sales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Repository.Outstanding
{
    public class OutstandingRepository
    {
        OutstandingDTO DTO = new OutstandingDTO();
        DataConnection db = new DataConnection();
        SqlConnection myConnection = null;

        public List<OutstandingDTO> get_OutstandingSummary(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<OutstandingDTO> SD = new List<OutstandingDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_OUTSTANDING_SUMMARY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    DTO.ZoneID = reader["ZoneId"].ToString();
                    DTO.ZoneCode = reader["ZoneCode"].ToString();
                    DTO.DueAmount = reader["DueAmount"].ToString();
                    DTO.OustStanding = reader["OustStanding"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(DTO);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<OutstandingDTO> get_BranchWise_OutstandingSummary(string USERID, string ZONEID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<OutstandingDTO> SD = new List<OutstandingDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_OUTSTANDING_SUMMARY_BRANCH_WISE", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@ZoneID", ZONEID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    DTO.BranchId = reader["BranchId"].ToString();
                    DTO.BranchCode = reader["BranchCode"].ToString();
                    DTO.DueAmount = reader["DueAmount"].ToString();
                    DTO.OustStanding = reader["OustStanding"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(DTO);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<OutstandingDTO> get_BranchRout_OutstandingSummary(string USERID, string BRANCHID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<OutstandingDTO> SD = new List<OutstandingDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_OUTSTANDING_SUMMARY_ROUTE_WISE", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@BranchID", BRANCHID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    DTO.RouteID = reader["RouteID"].ToString();
                    DTO.RouteName = reader["RouteName"].ToString();
                    DTO.DueAmount = reader["DueAmount"].ToString();
                    DTO.OustStanding = reader["OustStanding"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(DTO);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<OutstandingDTO> get_Customer_OutstandingSummary(string USERID, string RouteID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<OutstandingDTO> SD = new List<OutstandingDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_OUTSTANDING_SUMMARY_CUSTOMER_WISE", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@RouteID", RouteID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    DTO.CustomerID = reader["CustomerID"].ToString();
                    DTO.CustomerName = reader["CustomerName"].ToString();
                    DTO.DueAmount = reader["DueAmount"].ToString();
                    DTO.OustStanding = reader["OustStanding"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(DTO);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<OutstandingDTO> get_Customer(string USERID, string CUSTOMERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<OutstandingDTO> SD = new List<OutstandingDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_SALES_OUTSTANDING_SUMMARY_CUSTOMER", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@CUSTOMERID", CUSTOMERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    DTO.CustomerID = reader["CustomerID"].ToString();
                    DTO.ZoneName = reader["ZoneName"].ToString();
                    DTO.SalesOffice = reader["SalesOffice"].ToString();
                    DTO.BranchName = reader["BranchName"].ToString();
                    DTO.RouteName = reader["RouteName"].ToString();
                    DTO.CustomerName = reader["CustomerName"].ToString();
                    DTO.OustStanding = reader["OustStanding"].ToString();
                    DTO.DueAmount = reader["DueAmount"].ToString();
                    DTO.CreditLimit = reader["CreditLimit"].ToString();
                    DTO.CreditPeriod = reader["CreditPeriod"].ToString();
                    DTO.DueDate = reader["DueDate"].ToString();
                    DTO.GreenChannel = reader["GreenChannel"].ToString();
                    DTO.SchemeCustomer = reader["SchemeCustomer"].ToString();
                    DTO.PaymentMode = reader["PaymentMode"].ToString();
                    DTO.AvgCollectionPeriod = reader["AvgCollectionPeriod"].ToString();
                    DTO.MappedSA = reader["MappedSA"].ToString();
                    DTO.RegistrationType = reader["RegistrationType"].ToString();
                    DTO.ChequeReturnCount = reader["ChequeReturnCount"].ToString();
                    DTO.LeaderName = reader["LeaderName"].ToString();
                    DTO.GOName = reader["GOName"].ToString();
                    DTO.SMName = reader["SMName"].ToString();
                    DTO.VisitedDay = reader["VisitedDay"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(DTO);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }
    }
}
