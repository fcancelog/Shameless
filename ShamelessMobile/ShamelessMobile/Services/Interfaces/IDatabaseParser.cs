using ShamelessMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessMobile.Services.Interfaces
{
    public interface IDatabaseParser
    {
        void DownloadDatabase(string outputFile);
        void DownloadSizes(string outputFile);
        Nintendo3DSTitle[] ParseFromDatabase(string databasePath, string sizesPath);
        string HumanReadableFileSize(long size);
    }
}
