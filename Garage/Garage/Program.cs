using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Garage
{
    // the main program that runs everything
    public static class Program
    {
        public static HttpClient client;
        // enter the ip address for the server
        public const string url = "http://localhost:3000/";

        [STAThread]
        static void Main()
        {
            // create an HttpClient with a custom handler that ignores SSL certificate errors
            client = CreateHttpClientWithIgnoreCertificateErrors();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        static HttpClient CreateHttpClientWithIgnoreCertificateErrors()
        {
            // create a handler that ignores SSL certificate errors
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            // create an HttpClient with the custom handler
            return new HttpClient(handler);
        }
    }
}
