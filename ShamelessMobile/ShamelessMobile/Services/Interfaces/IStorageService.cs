using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessMobile.Services.Interfaces
{
    public interface IStorageService
    {
        void SaveTextFile(string outputFile, string text);
        string LoadTextFile(string filePath);
    }
}
