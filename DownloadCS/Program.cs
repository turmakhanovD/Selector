using System;
using System.ComponentModel;
using System.Net;

namespace DownloadCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("https://download-cs.net/counter.php?dl=1");
            WebClient webClient = new WebClient();         
            webClient.DownloadFileAsync(address, @"C:\Users\ТурмаханД\Downloads\cs16.exe");
         
        }

      
    }
}
