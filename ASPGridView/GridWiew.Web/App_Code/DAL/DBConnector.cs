/// Class           :   DBConnector
///	Author			:	Md. Mahedee Hasan
///	Purpose			:	For Connecting with database
///	Creation Date	:	21/04/2012
/// ==================================================================================================
///  || Modification History ||
///  -------------------------------------------------------------------------------------------------
///  Sl No.	Date:		Author:			    Ver:	Area of Change:     
///  
///	**************************************************************************************************

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public class DBConnector
{
    private string connectionString = null;
    private SqlConnection sqlConn = null;
    private SqlCommand cmd = null;

    public DBConnector()
    {
        connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ToString();
    }

    public void SetMainConnectionString()
    {
        connectionString = ConfigurationManager.ConnectionStrings["BlueChipConnectionString"].ToString();
    }

    public SqlCommand GetCommand()
    {
        cmd = new SqlCommand();
        cmd.Connection = sqlConn;
        return cmd;
    }

    public SqlConnection GetConn()
    {
        sqlConn = new SqlConnection(connectionString);
        return sqlConn;
    }

}

