using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace mogelmodulupdater
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string inputfilepath = Directory.GetCurrentDirectory() + @"\mogelmodul.exe";
                string inputfilepathini = Directory.GetCurrentDirectory() + @"\mogelmodul.ini";


                if (File.Exists(inputfilepath))
                {
                    File.Delete(inputfilepath);
                }

                WebClient clientversion = new WebClient();
                string versionString = clientversion.DownloadString("https://auxilium.cc/auxilium.cc/mogelmodul/test.php");

                if (versionString == "The hack is up2date.")
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://auxilium.cc/auxilium.cc/mogelmodul/mogelmodul.exe", inputfilepath);
                }
                else
                {
                    Console.WriteLine("The hack is outdated.");
                    Console.ReadLine();
                    return;
                }

                if (!File.Exists(inputfilepathini))
                {

                    WebClient webClient2 = new WebClient();
                    webClient2.DownloadFile("https://auxilium.cc/auxilium.cc/mogelmodul/mogelmodul.ini", inputfilepathini);
                }

                Console.WriteLine("successful update");

                Process.Start(inputfilepath);
                System.Threading.Thread.Sleep(1000);
                return;

            }
            catch (Exception e)
            {
                Console.WriteLine("Fail! Contact the developer");
                Console.ReadLine();
                return;
            }
        }
    }
}
