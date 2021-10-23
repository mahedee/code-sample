///	Author			:	Md. Mahedee Hasan
///	Purpose			:	Code behind of Default.aspx page
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
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            Load_gvEmpInfo();
        }
    }


    /// <summary>
    /// Binding gridview gvEmpInfo
    /// </summary>
    private void Load_gvEmpInfo()
    {
        EmployeeInfoBLL objEmployeeInfoBLL = new EmployeeInfoBLL();
        this.gvEmpInfo.DataSource = objEmployeeInfoBLL.GetEmployeeInfoAll();
        this.gvEmpInfo.DataBind();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnEdit_Click(object sender, EventArgs e)
    {

        this.btnSave.Text = "Edit";

        LinkButton btnEdit = sender as LinkButton;
        
        //Identify the clicked row
        int rowIndex = Convert.ToInt32(btnEdit.Attributes["RowIndex"]);

        GridViewRow gvRow = this.gvEmpInfo.Rows[rowIndex];
        
        //Identify the hidden filed value of clicked row
        int emp_gid = Convert.ToInt32(((HiddenField)gvRow.FindControl("hidemp_gid")).Value);

        this.txtEmpFullNm.Text = gvRow.Cells[0].Text;
        this.txtEmpNickNm.Text = gvRow.Cells[1].Text;
        this.txtDesignation.Text = gvRow.Cells[2].Text;

        this.hf_emp_gid.Value = emp_gid.ToString();

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        LinkButton btnDelete = sender as LinkButton;

        //Identify the clicked row
        int rowIndex = Convert.ToInt32(btnDelete.Attributes["RowIndex"]);

        GridViewRow gvRow = this.gvEmpInfo.Rows[rowIndex];

        //Identify the hidden filed value of clicked row
        int emp_gid = Convert.ToInt32(((HiddenField)gvRow.FindControl("hidemp_gid")).Value);

        string msg = String.Empty;

        try
        {
            EmployeeInfoBLL objEmployeeInfoBLL = new EmployeeInfoBLL();
            msg = objEmployeeInfoBLL.RemoveEmployeeInfo(emp_gid);
            Load_gvEmpInfo();
            ClearForm();
        }
        catch (Exception exp)
        {
            msg = exp.Message;
        }


        //Javascript alert message from code behind
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script type=text/javascript>alert('" + msg + "')</script>");

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        String msg = String.Empty;
        Button btnSave = sender as Button;

        EmployeeInfoBLL objEmployeeInfoBLL = new EmployeeInfoBLL();
        EmployeeInfo objEmployeeInfo = new EmployeeInfo();
        objEmployeeInfo.EmpFullNm = this.txtEmpFullNm.Text;
        objEmployeeInfo.EmpNickNm = this.txtEmpNickNm.Text;
        objEmployeeInfo.EmpDesignation = this.txtDesignation.Text;

        try
        {
            if (btnSave.Text == "Edit")
            {
                objEmployeeInfo.EmpGid = Convert.ToInt32(this.hf_emp_gid.Value);
                msg = objEmployeeInfoBLL.EditEmployeeInfo(objEmployeeInfo);
                this.btnSave.Text = "Save";
            }
            else
            {
                msg = objEmployeeInfoBLL.SaveEmployeeInfo(objEmployeeInfo);
            }

            Load_gvEmpInfo();
            ClearForm();
        }
        catch (Exception exp)
        {
            msg = exp.Message;
        }

        //Javascript alert message from code behind
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script type=text/javascript>alert('" + msg + "')</script>");
    }


    /// <summary>
    /// Clear form
    /// </summary>
    private void ClearForm()
    {
        this.txtEmpFullNm.Text = "";
        this.txtEmpNickNm.Text = "";
        this.txtDesignation.Text = "";
    }
}
