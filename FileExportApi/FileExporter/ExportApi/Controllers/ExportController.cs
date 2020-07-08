using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExportApi.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        //Get: api/Export/GetExcel
        [HttpGet]
        [Route("GetExcel")]
        public IActionResult GetExcel()
        {
            try
            {
                return Ok(ConverExceltoB64());
            }

            catch (Exception ex)
            {

                throw (ex);
            }
        }





        //Get: api/Export/GetPDF
        [HttpGet]
        [Route("GetPDF")]
        public IActionResult GetPDF()
        {
            try
            {
                return Ok(ConvertPDFtoB64());
            }

            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //Get: api/Export/GetDynamicExcel
        [HttpGet]
        [Route("GetDynamicExcel")]
        public IActionResult GetDynamicExcel()
        {
            try
            {
                return Ok(BuildeExcel());
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        // Convert an excel file to Base64 
        private string ConverExceltoB64()
        {
            var docBytes = System.IO.File.ReadAllBytes(System.IO.Path.GetFullPath(@"files\booklist.xlsx"));
            string docBase64 = Convert.ToBase64String(docBytes);
            return (docBase64);
        }


        // Convert a pdf file to Base64
        private string ConvertPDFtoB64()
        {
            var docBytes = System.IO.File.ReadAllBytes(System.IO.Path.GetFullPath(@"files\mahedeebio.pdf"));
            string docBase64 = Convert.ToBase64String(docBytes);
            return (docBase64);
        }


        // Create an excel on the fly and return as Base64 format
        private string BuildeExcel()
        {
            StringBuilder table = new StringBuilder();
            table.Append("<table border=`" + "1px" + "`b>");
            table.Append("<tr>");
            table.Append("<td><b><font face=Arial Narrow size=3>ID</font></b></td>");
            table.Append("<td><b><font face=Arial Narrow size=3>Name</font></b></td>");
            table.Append("<td><b><font face=Arial Narrow size=3>Designation</font></b></td>");
            table.Append("</tr>");

            foreach (var item in GetEmployeeAll())
            {
                table.Append("<tr>");
                table.Append("<td><font face=Arial Narrow size=" + "14px" + ">" + item.Id.ToString() + "</font></td>");
                table.Append("<td><font face=Arial Narrow size=" + "14px" + ">" + item.Name.ToString() + "</font></td>");
                table.Append("<td><font face=Arial Narrow size=" + "14px" + ">" + item.Designation.ToString() + "</font></td>");
                table.Append("</tr>");
            }

            table.Append("</table>");
            byte[] temp = System.Text.Encoding.UTF8.GetBytes(table.ToString());
            return System.Convert.ToBase64String(temp);

        }


        // Return list of employee
        private List<Employee> GetEmployeeAll()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(){Id = 1, Name = "Sabrina Jahan Sara", Designation = "Software Engineer"},
                new Employee(){Id = 2, Name = "Tahiya Hasan Arisha", Designation = "Sr. Software Engineer"},
                new Employee(){Id = 3, Name = "Ishrat Jahan Nusaifa", Designation = "Software Architect"},
                new Employee(){Id = 4, Name = "Nusrat Janan", Designation = "Project Manager"}
            };

            return employees;
        }
    }


    // Employee model class
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}