namespace ShamelessMobile.Services.Interfaces
{
    public interface IWebService
    {
        void DownloadFile(string url, string filename);
        byte[] DownloadData(string url);
    }
}
