using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string file = @"C:\Program Files (x86)\GnuWin32\bin\wget.exe";
            //string cParams = @"wget http://speedtest.wdc01.softlayer.com/downloads/test10.zip";

            //var proc = Process.Start(file, cParams);


            //http://www.codeproject.com/Articles/6259/Monitoring-network-speed

            using (WebClient client = new WebClient())
            {
                string page = client.DownloadString("http://speedtest.wdc01.softlayer.com/downloads/test10.zip");
            }

            //We pauzeren het programma (debugging)
            Console.ReadLine();
        }
    }
}
