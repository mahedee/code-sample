using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections;
using CrystalDecisions.Shared;

/// <summary>
/// The base class to generate report document
/// </summary>
public class ReportBase
{

    string ServerName = "MAHEDEE-PC";    //Database server name to which report connected
    string DataBaseName = "TestDB";      //Database name to which report connected
    string UserID = "sa";                //Database user name to which report connected
    string Password = "sa";              //Database user password to which report connected

    ReportDocument crReportDocument = new ReportDocument();   //Crystal report document object

    

    public ReportBase()
    {
    }
    
    /// <summary>
    ///Base method to generate report document. 
    /// </summary>
    /// <param name="ReportName">Report name</param>
    /// <param name="ParamArraylist">Parameter ArrayList</param>
    /// <param name="ReportFolder">Report folder name</param>
    /// <returns></returns>
    
    public ReportDocument PFSubReportConnectionMainParameter(string ReportName, ArrayList ParamArraylist, string ReportFolder)
    {
        int ObjArrayA, ObjArrayB, Paraindex;
        string Paravalue;
        ObjArrayB = 0;

        string path = ReportFolder + @"\" + @ReportName; //Full path of report
        
        try
        {
            crReportDocument.Load(path); //Load crystal Report
        }
        catch (Exception ex)
        {

            string msg = "The report file " + path +
                        " can not be loaded, ensure that the report exists or the path is correct." +
                        "\nException:\n" + ex.Message +
                        "\nSource:" + ex.Source +
                        "\nStacktrace:" + ex.StackTrace;
            throw new Exception(msg);
        }

       //Ensure login to the database server
        if (!Logon(crReportDocument, ServerName, DataBaseName, UserID, Password))
        {
            string msg = "Can not login to Report Server " +
                        "\nDatabase Server: " + ServerName +
                        "\nDatabase:\n" + DataBaseName +
                        "\nDBUser:" + UserID +
                        "\nDBPassword:" + Password;
            throw new Exception(msg);
        }

        Logon(crReportDocument, ServerName, DataBaseName, UserID, Password);
        
        //To Check Parameter Feild Array have the Same Amount of Parameter Feild in the Report
        int ParamArrayCount, ParameterFieldCount;
        //Getting Value from the Array

        if (ParamArraylist.Count != 0)
        {
            ParamArrayCount = (ParamArraylist.Count / 2);

            //Getting Value From the Report (Parameter and Formula Feild)
            ParameterFieldCount = crReportDocument.DataDefinition.ParameterFields.Count;

            //Parameter on The Report and Array List Parameter Amount is not the same
            ParamArrayCount = ParameterFieldCount;

        
            for (ObjArrayA = 0; ObjArrayA < ((ParamArraylist.Count / 2)); ObjArrayA++)
            {
                Paraindex = (int)ParamArraylist[ObjArrayB]; //Parameter index
                Paravalue = (string)ParamArraylist[ObjArrayB + 1]; //Paramter Value
                PassParameter(Paraindex, Paravalue);
                ObjArrayB = ObjArrayB + 2;
            }
        }

        
        return crReportDocument;

    }

    /// <summary>
    /// Set parameter value in crystal report on corresponding index
    /// </summary>
    /// <param name="ParameterIndex"></param>
    /// <param name="ParameterValue"></param>
    public void PassParameter(int ParameterIndex, string ParameterValue)
    {
        //        '
        //        ' Declare the parameter related objects.
        //        '
        ParameterDiscreteValue crParameterDiscreteValue;
        ParameterFieldDefinitions crParameterFieldDefinitions;
        ParameterFieldDefinition crParameterFieldLocation;
        ParameterValues crParameterValues;


        crParameterFieldDefinitions = crReportDocument.DataDefinition.ParameterFields;
        crParameterFieldLocation = (ParameterFieldDefinition)crParameterFieldDefinitions[ParameterIndex];
        crParameterValues = crParameterFieldLocation.CurrentValues;
        crParameterDiscreteValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
        crParameterDiscreteValue.Value = System.Convert.ToString(ParameterValue);
        crParameterValues.Add(crParameterDiscreteValue);
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues);
    }

    //Check whether crytal report can login to the server
    private bool Logon(CrystalDecisions.CrystalReports.Engine.ReportDocument cr, string server, string database, string user_id, string password)
    {
        // Declare and instantiate a new connection info object.
        CrystalDecisions.Shared.ConnectionInfo ci;
        ci = new CrystalDecisions.Shared.ConnectionInfo();

        ci.ServerName = server;
        ci.DatabaseName = database;
        ci.UserID = user_id;
        ci.Password = password;//password;
        //  ci.IntegratedSecurity = false;

        // If the ApplyLogon function fails then return a false for this function.
        // We are applying logon information to the main report at this stage.
        if (!ApplyLogon(cr, ci))
        {
            return false;
        }

        // Declare a subreport object.
        CrystalDecisions.CrystalReports.Engine.SubreportObject subobj;

        // Loop through all the report objects and locate subreports.
        // If a subreport is found then apply logon information to
        // the subreport.
        foreach (CrystalDecisions.CrystalReports.Engine.ReportObject obj in cr.ReportDefinition.ReportObjects)
        {
            if (obj.Kind == CrystalDecisions.Shared.ReportObjectKind.SubreportObject)
            {
                subobj = (CrystalDecisions.CrystalReports.Engine.SubreportObject)obj;
                if (!ApplyLogon(cr.OpenSubreport(subobj.SubreportName), ci))
                {
                    return false;
                }
            }
        }

        // Return True if the code runs to this stage.
        return true;

    }

    /// <summary>
    ///This method is called by the "Logon" method. It loops through the report tables and applies the connection information to each table.
    /// </summary>
    /// <param name="cr"></param>
    /// <param name="ci"></param>
    /// <returns></returns>
    private bool ApplyLogon(CrystalDecisions.CrystalReports.Engine.ReportDocument cr, CrystalDecisions.Shared.ConnectionInfo ci)
    {
        // This function is called by the "Logon" function
        // It loops through the report tables and applies
        // the connection information to each table.

        // Declare the TableLogOnInfo object and a table object for use later.
        CrystalDecisions.Shared.TableLogOnInfo li;
        // For each table apply connection info.

        foreach (CrystalDecisions.CrystalReports.Engine.Table tbl in cr.Database.Tables)
        {

            li = tbl.LogOnInfo;
            li.ConnectionInfo.ServerName = ci.ServerName;
            li.ConnectionInfo.DatabaseName = ci.DatabaseName;
            li.ConnectionInfo.UserID = ci.UserID;
            li.ConnectionInfo.Password = ci.Password;
            tbl.ApplyLogOnInfo(li);
            tbl.Location = ci.DatabaseName + ".dbo." + tbl.Name;

            // Verify that the logon was successful.
            // If TestConnectivity returns false, correct table locations.
            if (!tbl.TestConnectivity())
            {
                return false;

            }
        }
        return true;
    }

}