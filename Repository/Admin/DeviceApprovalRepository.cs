using DTO.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Utilities;
using System.Data;

namespace Repository.Admin
{
    public class DeviceApprovalRepository
    {
        DeviceApprovalDTO approvalDTO = new DeviceApprovalDTO();
        DataConnection db = new DataConnection();
        SqlConnection myConnection = null;

        public DeviceApprovalRepository() { }

        public List<DeviceApprovalDTO> Device_Approval()
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<DeviceApprovalDTO> DA = new List<DeviceApprovalDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_MIS_APP_DEVICE_WAITING_FOR_APPROVAL", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //sqlCmd.Parameters.AddWithValue("@ZoneID", zone_id);
                //sqlCmd.Parameters.AddWithValue("@SalesOfficeID", saoffcid);
                //sqlCmd.Parameters.AddWithValue("@BranchID", branch_id);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    approvalDTO.DeviceID = reader["DeviceID"].ToString();
                    approvalDTO.UserName = reader["UserName"].ToString();
                    approvalDTO.DeviceIME = reader["DeviceIME"].ToString();
                    approvalDTO.LoginDate = reader["LoginDate"].ToString();
                    approvalDTO.EmployeeType = reader["EmployeeType"].ToString();
                    approvalDTO.Branch = reader["Branch"].ToString();
                    if (reader.HasRows == true)
                    {
                        DA.Add(approvalDTO);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return DA;
        }

        public List<DeviceApprovalDTO> Device_Approving(string DeviceID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<DeviceApprovalDTO> DA = new List<DeviceApprovalDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_MIS_APP_DEVICE_APPROVAL", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@DeviceID", DeviceID);
                //sqlCmd.Parameters.AddWithValue("@SalesOfficeID", saoffcid);
                //sqlCmd.Parameters.AddWithValue("@BranchID", branch_id);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    approvalDTO.DeviceID = reader["DeviceID"].ToString();
                    approvalDTO.UserName = reader["UserName"].ToString();
                    
                    if (reader.HasRows == true)
                    {
                        DA.Add(approvalDTO);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return DA;
        }

        public List<DeviceApprovalDTO> Device_Rejecting(string DeviceID)
        {
            SqlConnection myConnection = db.GetConnection();
            SqlDataReader reader = null;
            List<DeviceApprovalDTO> DA = new List<DeviceApprovalDTO>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SP_MIS_APP_DEVICE_REJECTION", myConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@DeviceID", DeviceID);
                //sqlCmd.Parameters.AddWithValue("@SalesOfficeID", saoffcid);
                //sqlCmd.Parameters.AddWithValue("@BranchID", branch_id);

                sqlCmd.Connection = myConnection;
                myConnection.Open();
                reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    approvalDTO.DeviceID = reader["DeviceID"].ToString();
                    approvalDTO.UserName = reader["UserName"].ToString();

                    if (reader.HasRows == true)
                    {
                        DA.Add(approvalDTO);
                    }
                }

                myConnection.Close();
            }
            catch (Exception ex) { }

            return DA;
        }

    }
}
