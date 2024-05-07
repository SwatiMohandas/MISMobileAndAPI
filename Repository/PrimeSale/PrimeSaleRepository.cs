using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using DTO.PrimeSale;

namespace Repository.PrimeSale
{
    public class PrimeSaleRepository
    {
        PrimeSaleDTO dto = new PrimeSaleDTO();
        DataConnection db = new DataConnection();
        SqlConnection myConnection = null;

        public List<PrimeSaleDTO> prime_summary_day(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.DivisionID = reader["DivisionID"].ToString();
                    dto.DivisionName = reader["DivisionName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_sm_day(string USERID, string DivisionID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.SMID = reader["SMID"].ToString();
                    dto.SMNAME = reader["SMNAME"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_day(string USERID, string DivisionID, string SMID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.LeaderID = reader["LeaderID"].ToString();
                    dto.Leader = reader["Leader"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_go_day(string USERID, string DivisionID, string SMID, string LeaderID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_GO_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);
                sqlCmd.Parameters.AddWithValue("@LeaderID", LeaderID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.GOID = reader["GOID"].ToString();
                    dto.GOName = reader["GOName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_go_CUSTOMER_day(string USERID, string DivisionID, string SMID, string LeaderID, string GOID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_GO_CUSTOMER_SUMMARY_DAY", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);
                sqlCmd.Parameters.AddWithValue("@LeaderID", LeaderID);
                sqlCmd.Parameters.AddWithValue("@GOID", GOID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.CustomerID = reader["CustomerID"].ToString();
                    dto.CustomerName = reader["CustomerName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_summary_month(string USERID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.DivisionID = reader["DivisionID"].ToString();
                    dto.DivisionName = reader["DivisionName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_sm_month(string USERID, string DivisionID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.SMID = reader["SMID"].ToString();
                    dto.SMNAME = reader["SMNAME"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_month(string USERID, string DivisionID, string SMID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.LeaderID = reader["LeaderID"].ToString();
                    dto.Leader = reader["Leader"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_go_month(string USERID, string DivisionID, string SMID, string LeaderID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_GO_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);
                sqlCmd.Parameters.AddWithValue("@LeaderID", LeaderID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.GOID = reader["GOID"].ToString();
                    dto.GOName = reader["GOName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_go_CUSTOMER_month(string USERID, string DivisionID, string SMID, string LeaderID, string GOID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_GO_CUSTOMER_SUMMARY_MONTH", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);
                sqlCmd.Parameters.AddWithValue("@LeaderID", LeaderID);
                sqlCmd.Parameters.AddWithValue("@GOID", GOID);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.CustomerID = reader["CustomerID"].ToString();
                    dto.CustomerName = reader["CustomerName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_summary_prd(string USERID, string Start_Date, string End_Date)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@Start_Date", Start_Date);
                sqlCmd.Parameters.AddWithValue("@End_Date", End_Date);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.DivisionID = reader["DivisionID"].ToString();
                    dto.DivisionName = reader["DivisionName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_sm_prd(string USERID, string DivisionID, string Start_Date, string End_Date)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@Start_Date", Start_Date);
                sqlCmd.Parameters.AddWithValue("@End_Date", End_Date);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.SMID = reader["SMID"].ToString();
                    dto.SMNAME = reader["SMNAME"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_prd(string USERID, string DivisionID, string SMID, string Start_Date, string End_Date)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);
                sqlCmd.Parameters.AddWithValue("@Start_Date", Start_Date);
                sqlCmd.Parameters.AddWithValue("@End_Date", End_Date);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.LeaderID = reader["LeaderID"].ToString();
                    dto.Leader = reader["Leader"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_go_prd(string USERID, string DivisionID, string SMID, string LeaderID, string Start_Date, string End_Date)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_GO_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);
                sqlCmd.Parameters.AddWithValue("@LeaderID", LeaderID);
                sqlCmd.Parameters.AddWithValue("@Start_Date", Start_Date);
                sqlCmd.Parameters.AddWithValue("@End_Date", End_Date);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.GOID = reader["GOID"].ToString();
                    dto.GOName = reader["GOName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

        public List<PrimeSaleDTO> prime_leader_CUSTOMER_go_prd(string USERID, string DivisionID, string SMID, string LeaderID, string GOID, string Start_Date, string End_Date)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<PrimeSaleDTO> SD = new List<PrimeSaleDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_GET_MIS_APP_PRIME_DIVISION_SM_LEADER_GO_CUSTOMER_SUMMARY_PERIOD", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@USERID", USERID);
                sqlCmd.Parameters.AddWithValue("@DivisionID", DivisionID);
                sqlCmd.Parameters.AddWithValue("@SMID", SMID);
                sqlCmd.Parameters.AddWithValue("@LeaderID", LeaderID);
                sqlCmd.Parameters.AddWithValue("@GOID", GOID);
                sqlCmd.Parameters.AddWithValue("@Start_Date", Start_Date);
                sqlCmd.Parameters.AddWithValue("@End_Date", End_Date);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.CustomerID = reader["CustomerID"].ToString();
                    dto.CustomerName = reader["CustomerName"].ToString();
                    dto.PrimeSale = reader["PrimeSale"].ToString();
                    dto.BillCount = reader["BillCount"].ToString();
                    if (reader.HasRows == true)
                    {
                        SD.Add(dto);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return SD;
        }

    }
}
