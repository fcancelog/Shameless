using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using ShamelessMobile.iOS.Services;
using Xamarin.Forms;
using ShamelessMobile.Services.Interfaces;
using System.Net;
using System.IO;
using ShamelessMobile.Resources;

[assembly: Dependency(typeof(WebService))]
namespace ShamelessMobile.iOS.Services
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