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

public partial class ReportViewer : System.Web.UI.Page
{

    ReportDocument ObjReportClientDocument = new ReportDocument();
    protected void Page_Load(object sender, EventArgs e)
    {
        //====Updated by Mahedee===27.09.11
        if (!Page.IsPostBack)
        {
            GetReportDocument();
        }

        ViewReport();
    }

    private void GetReportDocument()
    {
        clsReportBase objclsReportBase = new clsReportBase();
        string sRptFolder = string.Empty;
        string sRptName = string.Empty;

        ArrayList ParameterArrayList = new ArrayList();
        ParameterArrayList = (ArrayList)Session["parameterArrayList"];
        //this.lblTestDt.Text = ParameterArrayList[1].ToString();

        sRptName = "rpt_get_employee_info_dept_id_team_id.rpt";
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
        //return objReportDocument;
    }

    private void ViewReport()
    {
            //===============Updated by : Mahedee ==== 27.09.11=========
            GetReportDocument();
            CrystalReportViewer1.ReportSource = ObjReportClientDocument;
            //if(Session["ReportDoc"] != null)
            //    CrystalReportViewer1.ReportSource = (ReportDocument)Session["ReportDoc"]; 

    }

    protected void CrystalReportViewer1_ReportRefresh(object source, ViewerEventArgs e)
    {
        OnInit(e);
        ViewReport();
    }
}