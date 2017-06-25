using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using ShamelessMobile.Services.Interfaces;
using ShamelessMobile.iOS.Services;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(StorageService))]
namespace ShamelessMobile.iOS.Services
{
    public class StorageService : IStorageService
    {
        public string LoadTextFile(string fileName)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, fileName);
            return File.ReadAllText(filePath);
        }

        public void SaveTextFile(string outputFile, string text)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, outputFile);
            File.WriteAllText(filePath, text);
        }
    }
}