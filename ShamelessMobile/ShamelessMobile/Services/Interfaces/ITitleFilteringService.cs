using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessMobile.Services.Interfaces
{
    public interface ITitleFilteringService
    {
        TitleFilter ParseFilterSettings(string filterPath);
        void WriteFilterSettings(TitleFilter filter, string filterPath);
    }
}
