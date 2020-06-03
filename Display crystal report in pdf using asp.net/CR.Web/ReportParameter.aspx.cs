using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReportParameter : System.Web.UI.Page
{
    ArrayList ParameterArrayList = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnViewReport_Click(object sender, EventArgs e)
    {
        //ParameterArrayList.Add(0);
        //ParameterArrayList.Add(this.txtBranch.Text.Trim());
        //ParameterArrayList.Add(1);
        //ParameterArrayList.Add(this.txtGender.Text.Trim());


        //ParameterArrayList.Add(0);
        //ParameterArrayList.Add("01/01/2013");
        //ParameterArrayList.Add(1);
        //ParameterArrayList.Add("12/12/2013");
        //ParameterArrayList.Add(2);
        //ParameterArrayList.Add("1");

        ParameterArrayList.Add(0);
        ParameterArrayList.Add("1");
        ParameterArrayList.Add(1);
        ParameterArrayList.Add("1");


        Session["parameterArrayList"] = ParameterArrayList;

        Response.Redirect("ReportViewer.aspx");
        //Response.Redirect("ReportViewerPDF.aspx");


    }
}