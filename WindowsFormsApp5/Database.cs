using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace WindowsFormsApp5
{
    class DatabaseMain
    {
        //List of detentions
        XmlDocument studentDDB;
        //List of students
        XmlDocument std;

        public DatabaseMain()
        {
            studentDDB = new XmlDocument();
            try
            {
                studentDDB.Load("xmlDatabase.xml");
            }
            catch(FileNotFoundException)
            {
                //If file is not found create it.
                studentDDB.AppendChild(studentDDB.CreateXmlDeclaration("1.0" , "UTF-8" , null));

                studentDDB.AppendChild(studentDDB.CreateElement("VFPData"));

                studentDDB.Save("xmlDatabase.xml");
            }
            
            std = new XmlDocument();

            studentDDB.Save("xmlDatabase.xml");

            //TODO Add Dynamic Images folder to allow for easy updating between years
            std.Load("IMAGES/Student.xml");

        }
        public XmlNode addDetention(string studentID, string reason)
        {
            studentDDB = new XmlDocument();
            studentDDB.Load("xmlDatabase.xml");

            XmlNode newElem = studentDDB.CreateNode("element", "student", "");
            newElem.AppendChild
                (studentDDB.CreateNode("element" , "student_ID" , ""))
                .InnerText = studentID;
            newElem.AppendChild
                (studentDDB.CreateNode("element" , "reason" , ""))
                .InnerText = reason;
            newElem.AppendChild
                (studentDDB.CreateNode("element" , "time" , ""))
                .InnerText = DateTime.Now.ToShortTimeString();
            newElem.AppendChild
                (studentDDB.CreateNode("element" , "date" , ""))
                .InnerText = DateTime.Now.ToShortDateString();
            newElem.AppendChild
                (studentDDB.CreateNode("element" , "robo_call" , ""))
                .InnerText = "false";
            newElem.AppendChild
                (studentDDB.CreateNode("element" , "served" , ""))
                .InnerText = "false";
            newElem.AppendChild
                (studentDDB.CreateNode("element" , "date_to_serve" , ""))
                .InnerText = Support.AddBusinessDays(DateTime.Now,3).ToShortDateString();

            studentDDB.SelectSingleNode("VFPData").AppendChild(newElem);

            studentDDB.Save("xmlDatabase.xml");
            return newElem;
        }

        public void addDetention(string studentID , string reason, int daysTilServed )
        {
            addDetention(studentID , reason).AppendChild
                (studentDDB.CreateNode("element" , "date to serve" , ""))
                .InnerText = Support.AddBusinessDays(DateTime.Now , daysTilServed).ToShortTimeString();


        }

        //TODO add albiity to select what part of name is needed by using Enum
        public string getName(string studentID)
        {
            XmlNode node = std.SelectSingleNode("/VFPData/subject[student_id_num =" + studentID +  "]");

            return node.SelectSingleNode("first_name").InnerText + " " + node.SelectSingleNode("last_name").InnerText;
        }
        public string getGrade(string studentID)
        {
            XmlNode node = std.SelectSingleNode("/VFPData/subject[student_id_num =" + studentID +  "]");

            return node.SelectSingleNode("grade").InnerText;
        }
        public string getStudentID(string studentID)
        {
            XmlNode node = std.SelectSingleNode("/VFPData/subject[student_id_num =" + studentID +  "]");

            return node.SelectSingleNode("student_id_num").InnerText;
        }
        public string getImageName(string studentID)
        {
            XmlNode node = std.SelectSingleNode("/VFPData/subject[student_id_num =" + studentID +  "]");

            return node.SelectSingleNode("image_name").InnerText;
        }


        public string getTotalDetention(string studentID)
        {

            XmlNodeList nodeL = studentDDB.SelectNodes("/VFPData/student[student_ID =" + studentID + "]");

            return nodeL.Count.ToString();
        }

        public XmlNodeList getDetentionList(string studentID)
        {
            XmlNodeList nodeL = studentDDB.SelectNodes("/VFPData/student[student_ID =" + studentID + "]");

            return nodeL;
        }


        public static string formatHTMLTable(XmlNodeList nodeL)
        {
            StringBuilder html = new StringBuilder(250);

            html.Append("<h2>All Detention's on File</h2> <table style=\"width:50%\">");

            html.Append("<tr>");
            html.Append("<th>Reason</th>");
            html.Append("<th>Time</th>");
            html.Append("<th>Date Issued</th>");
            html.Append("<th>Date To Be Served</th>");
            html.Append("<th>Served</th>");
            html.Append("<th>Call Home</th>");

            html.Append("</tr>");

            for(int i = 0; i < nodeL.Count; i++)
            {
                html.Append("<tr>");

                html.Append("<td>"+(nodeL.Item(i).SelectSingleNode("reason").InnerText) + "</td>");
                html.Append("<td>"+(nodeL.Item(i).SelectSingleNode("time").InnerText)+"</td>");
                html.Append("<td>" + (nodeL.Item(i).SelectSingleNode("date").InnerText) + "</td>");
                html.Append("<td>" + (nodeL.Item(i).SelectSingleNode("date_to_serve").InnerText) + "</td>");
                html.Append("<td>" + (nodeL.Item(i).SelectSingleNode("served").InnerText) + "</td>");
                html.Append("<td>" + (nodeL.Item(i).SelectSingleNode("robo_call").InnerText) + "</td>");

                html.Append("</tr>");

            }

            html.Append("</table>");

            return html.ToString();
        }

    }
}
