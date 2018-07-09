using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApp5
{
    class Support
    {

        public static DateTime AddBusinessDays(DateTime date , int days)
        {
            
            if(days < 0)
            {
                throw new ArgumentException("days cannot be negative" , "days");
            }

            if(days == 0) return date;

            if(date.DayOfWeek == DayOfWeek.Saturday)
            {
                date = date.AddDays(2);
                days -= 1;
            }
            else if(date.DayOfWeek == DayOfWeek.Sunday)
            {
                date = date.AddDays(1);
                days -= 1;
            }

            date = date.AddDays(days / 5 * 7);
            int extraDays = days % 5;

            if((int) date.DayOfWeek + extraDays > 5)
            {
                extraDays += 2;
            }

            return date.AddDays(extraDays);
        }

        public static Boolean checkAllServerStat()
        {
            try
            {
                var endPoint = new IPEndPoint(IPAddress.Parse("10.0.0.131"),6666);
                var c = new TcpClient();

                c.Connect(endPoint);

                NetworkStream s = c.GetStream();

                Byte[] data = Encoding.UTF8.GetBytes("Hello Friend");

                s.Write(data , 0 , data.Length);

                return true;

            } catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("CONNECTION ERROR");
            }

            return true;
            
        }
        
    }

    

}
