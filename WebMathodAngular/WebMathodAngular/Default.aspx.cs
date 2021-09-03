using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMathodAngular
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<Student> GetStudent()
        {
            List<Student> lstStudents = new List<Student>()
                {
				new Student { Id= 1, Name= "Mahedee Hasan", Semester="5th", Credits= 15},
				new Student { Id= 2, Name= "Robiul Alam", Semester="4th", Credits= 20},
				new Student { Id= 3, Name= "Amit Karmaker", Semester="7th", Credits= 12 },
				new Student { Id= 4, Name= "Zahid Hasan", Semester="8th", Credits= 18},
				new Student { Id= 5, Name= "Shafiqul Islam", Semester="6th", Credits= 15},
				
			};

            return lstStudents;
        }


    }


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Semester { get; set; }
        public int Credits { get; set; }
    }

}