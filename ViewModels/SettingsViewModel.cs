using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        private SettingsCommand addressChangeCommand;
        private FormattedAddress selectedAddress;

        public SettingsViewModel(IGeocodingService geocodingService)
        {
            this.geocodingService = geocodingService;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public ICommand AddressChangeCommand
        {
            get
            {
                if (addressChangeCommand == null)
                    addressChangeCommand = new SettingsCommand(GetNewAddresses, CanChangeAddress);
                return addressChangeCommand;
            }
        }

        private bool CanChangeAddress(object parameter)
        {
            FormattedAddress currentSelectedAddress = parameter as FormattedAddress;
            if (selectedAddress == null)
                return false;
            return true;
        }

        private async void GetNewAddresses(object parameter)
        {
            await geocodingService.GetFormattedAddressAsync("");
        }
    }
}
