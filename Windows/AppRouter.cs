using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Windows;

namespace WeatherApp.ViewModels
{
    public class AppRouter
    {
        private Settings settings;
        public void OpenSettings()
        {
            settings= new Settings();
            settings.Show();
        }
        public void CloseSettings()
        {
            settings?.Close();
        }
    }
}
