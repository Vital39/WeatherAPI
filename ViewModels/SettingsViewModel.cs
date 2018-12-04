using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Interfaces;

namespace WeatherApp.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        private readonly IGeocodingService geocodingService;

        public SettingsViewModel(IGeocodingService geocodingService)
        {
            this.geocodingService = geocodingService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
