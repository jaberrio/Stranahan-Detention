using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;


//https://codehosting.net/blog/BlogEngine/post/Simple-C-Web-Server

namespace SimpleWebServer
{
    public class WebServer
    {
        private readonly HttpListener _listener = new HttpListener();
        private readonly Func<HttpListenerRequest, string> _responderMethod;

        public WebServer(string[] prefixes , Func<HttpListenerRequest , string> method)
        {
            
            // URI prefixes are required, for example 
            // "http://localhost:8080/index/".
            if(prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            // A responder method is required
            if(method == null)
                throw new ArgumentException("method");

            foreach(string s in prefixes)
                _listener.Prefixes.Add(s);

            _responderMethod = method;
            _listener.Start();
        }

        public WebServer(Func<HttpListenerRequest , string> method , params string[] prefixes)
            : this(prefixes , method)
        { }

        public void Run()
        {
            ThreadPool.QueueUserWorkItem((webMaster) =>
            {
                Console.WriteLine("Webserver running...");
                try
                {
                    while(_listener.IsListening)
                    {
                        ThreadPool.QueueUserWorkItem((webChild) =>
                        {
                            var ctx = webChild as HttpListenerContext;
                            try
                            {
                                string rstr = _responderMethod(ctx.Request);
                                byte[] buf = Encoding.UTF8.GetBytes(rstr);
                                ctx.Response.ContentLength64 = buf.Length;
                                ctx.Response.OutputStream.Write(buf , 0 , buf.Length);
                            }
                            catch { } // suppress any exceptions
                            finally
                            {
                                // always close the stream
                                ctx.Response.OutputStream.Close();
                            }
                        } , _listener.GetContext());
                    }
                }
                catch(Exception e) { Console.WriteLine(e); } // suppress any exceptions
            });
        }



        public void Stop()
        {
            _listener.Stop();
            _listener.Close();
        }
    }
    public class TcpServer
    {
        //Force any Ip adresss, this is really bad practirce but BCPS doesn't know how to do anything corretly so w.e
        //Also the Port must be 6666 because logic need to apply
        private readonly TcpListener _tcpListener = new TcpListener(IPAddress.Any,6666);
        
        //Function that will procress the client TCP request
        private readonly Func<TcpClient,NetworkStream,string,string> procClientRec;

        public TcpServer(Func<TcpClient , NetworkStream , string , string> p)
        {
            procClientRec = p;
            _tcpListener.Start();
             
             
        }

        public void run()
        {
            ThreadPool.QueueUserWorkItem((tcpMaster) =>
            {
                Console.WriteLine("Master TCP server Running");

                while(true)
                {
                    TcpClient c = _tcpListener.AcceptTcpClient();

                    ThreadPool.QueueUserWorkItem((tcpChild) =>
                    {

                        NetworkStream stream = c.GetStream();
                        Byte[] bytes = new Byte[256];

                        int i;

                        while((i = stream.Read(bytes , 0 , bytes.Length)) != 0)
                        {

                            String data = null;

                            // Translate data bytes to a ASCII string.
                            data = Encoding.UTF8.GetString(bytes , 0 , i);
                            
                            procClientRec(c , stream , data);

                        }
                        c.Close();
                    });
                    
                }
            });
        }

        public void stop()
        {
            _tcpListener.Stop();
            
        }

    }
}