using SimpleWebServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class ServerRecorder : Form
    {
        static DatabaseMain db;

        public ServerRecorder()
        {
            InitializeComponent();

            db = new DatabaseMain();
        }

        private void checkBox1_CheckedChanged(object sender , EventArgs e)
        {
            if(checkBox1.Checked)
            {
                WebServer ws = new WebServer(SendResponse, "http://localhost:8080/");
                ws.Run();
            }
        }


        //Selects which subpage to load by taking a look at the /location

        public static string SendResponse(HttpListenerRequest request)
        {
            string url = request.RawUrl;
            Console.WriteLine(url);

            string[] urlS = url.Split('/');

            switch(urlS[1])
            {
                case "id":
                    return studentInformation(urlS[2]);

                default:
                    break;
            }
            

            return string.Format("<HTML><BODY>Page not found error.<br>{0}</BODY></HTML>" , DateTime.Now);
        }


        
        //Student information subpage
        public static string studentInformation(string id)
        {
            //Check if ID is formatted correctly
            
            return string.Format(
                "<HTML><BODY>" +

                "<head> <title>Stranahan Detention System</title> </head>" +
                
                "Hello User. {0}<br>{1}<br>" +
                "{2}" +

                "</BODY></HTML>"

                , DateTime.Now
                , db.getName(id)
                , DatabaseMain.formatHTMLTable(db.getDetentionList(id))
                );
        }




    }
}
