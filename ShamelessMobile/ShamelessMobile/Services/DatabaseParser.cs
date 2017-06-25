using ShamelessMobile.Resources;
using ShamelessMobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessMobile.Services
{
    public class DatabaseParser : IDatabaseParser
    {
        public async void DownloadDatabase(string outputFile)
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(URLs.Json_Enc);
            
        }
    }
}
