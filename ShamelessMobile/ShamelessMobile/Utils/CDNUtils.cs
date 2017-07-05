using ShamelessMobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShamelessMobile.Utils
{
    public static class CDNUtils
    {
        public static async void GetTitleSize(string titleId, Action<int> okAction, Action<Exception> errorAction)
        {
            throw new NotImplementedException();
            /*
            IWebService _webService = DependencyService.Get<IWebService>();
            var cdnUrl = "http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/" + titleId.ToUpper();
            byte[] tmd = _webService.DownloadData(cdnUrl + "/tmd");

            const int TikOffset = 0x140;

            var contentCount = Convert.ToInt32(BitConversion.BytesToHex(tmd.Skip(TikOffset + 0x9E).Take(2)), 16);

            long size = 0;

            for (int i = 0; i < contentCount; i++)
            {
                var contentOffset = 0xB04 + 0x30 * i;
                var contentId = BitConversion.BytesToHex(tmd.Skip(contentOffset).Take(4));

                try
                {
                    var req = WebRequest.Create(cdnUrl + "/" + contentId);
                    Task<WebResponse> requestTask = Task.Factory.FromAsync<WebResponse>
                        (req.BeginGetResponse, req.EndGetResponse, req);

                    using(var response = await requestTask)
                    {
                        long currentSize;
                        if (long.TryParse(response.Headers.AllKeys.First(x => x == "Content-Length"), out currentSize))
                        {
                            size += currentSize;
                        }
                    }
                }
                catch (WebException)
                {
                }
                */
            }
        }
    }
}
