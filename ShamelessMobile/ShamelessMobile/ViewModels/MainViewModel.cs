using ShamelessMobile.Resources;
using ShamelessMobile.Services;
using ShamelessMobile.Services.Interfaces;
using ShamelessMobile.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShamelessMobile.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        IDatabaseParser _databaseParser;

        public MainViewModel()
        {
            _databaseParser = new DatabaseParser();
            string a = String.Empty;
        }

        public ICommand CommandTest
        {
            get
            {
                return new Command(() =>
               {
                   _databaseParser.DownloadDatabase(Files.DBFileName);
               });
            }
        }
    }
}
