using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Web;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewReport : System.Web.UI.Page
{
    ArrayList ParameterArrayList = new ArrayList();
    ReportDocument ObjReportClientDocument = new ReportDocument();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnViewReport_Click(object sender, EventArgs e)
    {
        ParameterArrayList.Add(0);
        ParameterArrayList.Add(this.txtBranch.Text.Trim());
        ParameterArrayList.Add(1);
        ParameterArrayList.Add(this.txtGender.Text.Trim());

        GetReportDocument();
        ViewCystalReport();
        //CrystalReportViewer1.ReportSource = ObjReportClientDocument;

    }

    private void GetReportDocument()
    {

        clsReportBase objclsReportBase = new clsReportBase();
        string sRptFolder = string.Empty;
        string sRptName = string.Empty;

        //ArrayList ParameterArrayList = new ArrayList();
        //ParameterArrayList = SessionUtility.SessionContainer.ParameterArrayList;
        //this.lblTestDt.Text = ParameterArrayList[1].ToString();

        sRptName = "rpt_get_employee_info_barnch_gender.rpt";
        sRptFolder = Server.MapPath("~/Reports");


        ObjReportClientDocument = objclsReportBase.PFSubReportConnectionMainParameter(sRptName, ParameterArrayList, sRptFolder);
        //// added by sarwar to  decrease font size less 1
        foreach (Section oSection in ObjReportClientDocument.ReportDefinition.Sections)
        {
            foreach (ReportObject obj in oSection.ReportObjects)
            {
                FieldObject field;
                field = ObjReportClientDocument.ReportDefinition.ReportObjects[obj.Name] as FieldObject;



                if (field != null)
                {
                    Font oFon1 = new Font("Arial Narrow", field.Font.Size - 1F);
                    Font oFon2 = new Font("Arial", field.Font.Size - 1F);

                    if (oFon1 != null)
                    {
                        field.ApplyFont(oFon1);
                    }
                    else if (oFon2 != null)
                    {
                        field.ApplyFont(oFon2);
                    }
                }
            }
        }

        //Session["ReportDoc"] = ObjReportClientDocument;
        //return ObjReportClientDocument;
    }

    protected void CrystalReportViewer1_ReportRefresh(object source, ViewerEventArgs e)
    {
        OnInit(e);
        ViewCystalReport();
    }

    private void ViewCystalReport()
    {
        //===============Updated by : Mahedee ==== 27.09.11=========
        GetReportDocument();
        CrystalReportViewer1.ReportSource = ObjReportClientDocument;


    }

}