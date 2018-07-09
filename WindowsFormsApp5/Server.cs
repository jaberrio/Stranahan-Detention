using SimpleWebServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class ServerRecorder : Form
    {
        static DatabaseMain db;
        static WebServer ws;
        static TcpServer ts;

        public ServerRecorder()
        {
            InitializeComponent();

            db = new DatabaseMain();
        }

        private void checkBox1_CheckedChanged(object sender , EventArgs e)
        {
            if(checkBox1.Checked)
            {
                ws = new WebServer(SendResponse , "http://localhost:8080/");
                ws.Run();
            }
            else ws.Stop();
        }


        //Selects which subpage to load by taking a look at the /location

        public static string SendResponse(HttpListenerRequest request)
        {
            string url = request.RawUrl;
            Console.WriteLine(url);

            string[] urlS = url.Split('/');

            //example /id/

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

        private void checkBox2_CheckedChanged(object sender , EventArgs e)
        {
            if(checkBox2.Checked)
            {
                ts = new TcpServer(tcpDataPro);
                ts.run();
            }
            else ts.stop();
        }

        private string tcpDataPro(TcpClient tcpClient , NetworkStream networkStream , string data)
        {

            Console.WriteLine("Received: {0}" , data);

            return null;
        }
    }
}
