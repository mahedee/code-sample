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
    
    ArrayList ParameterArrayList = new ArrayList(); //Report parameter list
    ReportDocument ObjReportClientDocument = new ReportDocument(); //Report document

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnViewReport_Click(object sender, EventArgs e)
    {
        /*The report with two parameters. */
        ParameterArrayList.Add(0);
        ParameterArrayList.Add("1"); //Parameter 1 with input 1. This is actually dept id according to report parameter
        ParameterArrayList.Add(1); 
        ParameterArrayList.Add("1"); //Parameter 2 with input 1. This is actually team id according to report parameter

        GetReportDocument(); //Generate Report document
        ViewCystalReport();  //View report document in crystal report viewer

    }



    /*Generate report document*/
    private void GetReportDocument()
    {
        ReportBase objReportBase = new ReportBase();
        string sRptFolder = string.Empty;
        string sRptName = string.Empty;

        sRptName = "rpt_get_employee_info_dept_id_team_id.rpt"; //Report name
        sRptFolder = Server.MapPath("~/Reports");  //Report folder name


        ObjReportClientDocument = objReportBase.PFSubReportConnectionMainParameter(sRptName, ParameterArrayList, sRptFolder);
        

        //This section is for manipulating font and font size. This an optional section 
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
    }

    protected void CrystalReportViewer1_ReportRefresh(object source, ViewerEventArgs e)
    {
        //OnInit(e);
        //ViewCystalReport();
    }

    /// <summary>
    /// To view crystal report
    /// </summary>
    private void ViewCystalReport()
    {

        //Set generated report document as Crystal Report viewer report source
        CrystalReportViewer1.ReportSource = ObjReportClientDocument;
    }

}