using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessMobile.Models
{
    public class Nintendo3DSTitle
    {
        public Nintendo3DSTitle(string titleId, string encKey, string name, string type, string region, string serial, long size)
        {

        }

        public string  TitleId { get; set; }
        public string EncKey { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Region { get; set; }
        public string Serial { get; set; }
        public long Size { get; set; }
        public string HumanReadableSize { get; set; }

        public static string GetTitleType(string titleId)
        {
            var titleTypes = new Dictionary<string, string>
            {
                { "00040000", "eShop" },
                { "00040010", "System Application" },
                { "0004001B", "System Data Archive" },
                { "000400DB", "System Data Archive" },
                { "0004009B", "System Data Archive" },
                { "00040030", "System Applet" },
                { "00040130", "System Module" },
                { "00040138", "System Firmware" },
                { "00040001", "Download Play Title" },
                { "00048005", "DSIWare System Application" },
                { "0004800F", "DSIWare System Data Archive" },
                { "00048000", "DSIWare" },
                { "00048004", "DSIWare" },
                { "0004000E", "Update" },
                { "00040002", "Demo" },
                { "0004008C", "DLC" }
            };

            var choppedTittleId = titleId.Substring(0, 8).ToUpper();
            return titleTypes.ContainsKey(choppedTittleId) ? titleTypes[choppedTittleId] : "Unkonwn Type";
        }

        public override bool Equals(object obj)
        {
            var other = obj as Nintendo3DSTitle;
            return this.TitleId.Equals(other.TitleId, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return this.TitleId != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(this.TitleId) : 0;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", this.TitleId, this.Name);
        }
    }
}
