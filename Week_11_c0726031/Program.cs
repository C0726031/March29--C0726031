using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Week_11_c0726031
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Downloading file");
                Download();
                Console.ReadLine();
            }

            static async void Download()
            {
                await Network.Download();
                Console.WriteLine("Download complete");
            }

        class Network
        {
            public static async Task Download() {

                HttpClient client = new HttpClient();
                var data = await client.GetStringAsync("htttp://torontopubliclibrary.ca");
                Console.WriteLine(data);
            }
        }
    }
}

        
    

