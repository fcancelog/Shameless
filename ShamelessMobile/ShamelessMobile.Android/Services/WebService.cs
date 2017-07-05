using System;
using ShamelessMobile.Services.Interfaces;
using System.Net;
using ShamelessMobile.Resources;
using System.IO;
using Xamarin.Forms;
using ShamelessMobile.Droid.Services;

[assembly: Dependency(typeof(WebService))]
namespace ShamelessMobile.Droid.Services
{
    public class WebService : IWebService
    {
        public byte[] DownloadData(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadData(url);
        }

        public void DownloadFile(string url, string filename)
        {
            WebClient client = new WebClient();
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            client.DownloadFile(url, filePath);
        }
    }
}