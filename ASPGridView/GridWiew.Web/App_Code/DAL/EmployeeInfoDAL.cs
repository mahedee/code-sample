/// Class           :   EmployeeInfoDAL
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	Retreving data from database
///	Creation Date	:	21/04/2012
/// ==================================================================================================
///  || Modification History ||
///  -------------------------------------------------------------------------------------------------
///  Sl No.	Date:		Author:			    Ver:	Area of Change:     
///  
///	**************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for EmployeeInfoDAL
/// </summary>
public class EmployeeInfoDAL
{

    private SqlConnection sqlConn;
    private SqlCommand cmd;

    private readonly DBConnector objDBConnector;


    /// <summary>
    /// Constructor
    /// </summary>
    public EmployeeInfoDAL()
    {
        objDBConnector = new DBConnector();
        sqlConn = objDBConnector.GetConn();
        cmd = objDBConnector.GetCommand();
    }


    /// <summary>
    /// Get all employee information
    /// </summary>
    /// <returns></returns>
    public DataTable GetEmployeeInfoAll()
    {
        DataTable tblEmpInfo = new DataTable();
        SqlDataReader rdr = null;

        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT emp_gid, emp_fullnm, emp_nicknm, emp_designation FROM hrm_employee";

        try
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();

            rdr = cmd.ExecuteReader();
            tblEmpInfo.Load(rdr);
        }
        catch (Exception exp)
        {
            throw (exp);
        }
        finally
        {
            if (sqlConn.State == ConnectionState.Open)
                sqlConn.Close();
        }

        return tblEmpInfo;

    }


    /// <summary>
    /// Insert Employee information
    /// </summary>
    /// <param name="objEmployeeInfo"></param>
    /// <returns></returns>
    public string InsertEmployeeInfo(EmployeeInfo objEmployeeInfo)
    {
        string msg = String.Empty;

        int noOfRowEffected = 0;

        try
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO hrm_employee(emp_fullnm , emp_nicknm , emp_designation)"
                                + " VALUES('" + objEmployeeInfo.EmpFullNm + "','" + objEmployeeInfo.EmpNickNm + "','" + objEmployeeInfo.EmpDesignation + "')";
            noOfRowEffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        catch (Exception exp)
        {
            throw (exp);
        }
        finally
        {
            if (sqlConn.State == ConnectionState.Open)
                sqlConn.Close();
        }

        if (noOfRowEffected > 0)
            return "Employee information saved successfully!";
        else
            return msg;
    }



    /// <summary>
    /// Update employee information
    /// </summary>
    /// <param name="objEmployeeInfo"></param>
    /// <returns></returns>
    public string UpdateEmployeeInfo(EmployeeInfo objEmployeeInfo)
    {
        string msg = String.Empty;

        int noOfRowEffected = 0;

        try
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE hrm_employee SET emp_fullnm = '" + objEmployeeInfo.EmpFullNm +
                                "',emp_nicknm = '" + objEmployeeInfo.EmpNickNm + "', emp_designation = '" + objEmployeeInfo.EmpDesignation
                                + "' WHERE emp_gid = " + objEmployeeInfo.EmpGid;

            noOfRowEffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        catch (Exception exp)
        {
            throw (exp);
        }
        finally
        {
            if (sqlConn.State == ConnectionState.Open)
                sqlConn.Close();
        }

        if (noOfRowEffected > 0)
            return "Employee information updated successfully!";
        else
            return msg;
    }



    /// <summary>
    /// Delete employee information
    /// </summary>
    /// <param name="objEmployeeInfo"></param>
    /// <returns></returns>
    public string DeleteEmployeeInfo(int empGid)
    {
        string msg = String.Empty;

        int noOfRowEffected = 0;

        try
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM hrm_employee"
                                + " WHERE emp_gid = " + empGid;

            noOfRowEffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        catch (Exception exp)
        {
            throw (exp);
        }
        finally
        {
            if (sqlConn.State == ConnectionState.Open)
                sqlConn.Close();
        }

        if (noOfRowEffected > 0)
            return "Employee information deleted successfully!";
        else
            return msg;
    }


}