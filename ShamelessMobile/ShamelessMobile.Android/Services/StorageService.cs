using System;
using Android.App;
using Android.Content;
//using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using ShamelessMobile.Droid.Services;
using ShamelessMobile.Services.Interfaces;
using System.IO;

[assembly: Dependency(typeof(StorageService))]
namespace ShamelessMobile.Droid.Services
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