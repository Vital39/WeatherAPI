using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp.BusinessModels;
using WeatherApp.Commands;
using WeatherApp.Interfaces;

namespace WeatherApp.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        private readonly IGeocodingService geocodingService;
        private IList<FormattedAddress> addresses;
        private string text;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
                GetNewAddresses(text);
            }
        }

        public IList<FormattedAddress> Addresses
        {
            get
            {
                return addresses;
            }

            set
            {
                addresses = value;
                OnPropertyChanged();
            }
        }

        public SettingsViewModel(IGeocodingService geocodingService)
        {
            this.geocodingService = geocodingService;
        }


        private async void GetNewAddresses(string address)
        {
            if (string.IsNullOrEmpty(address))
                return;
            Addresses = await geocodingService.GetFormattedAddressAsync(address);
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
