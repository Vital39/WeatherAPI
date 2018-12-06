using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WeatherApp.BusinessModels;
using WeatherApp.Commands;
using WeatherApp.Interfaces;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        private readonly IGeocodingService geocodingService;
        private ConfigEditor configEditor = new ConfigEditor();
        private MessegeBoxService messegeBoxService = new MessegeBoxService();
        private IList<FormattedAddress> addresses;
        private string text;
        private bool isDropDownOpen;
        private bool isEnableComboBox;
        private bool isCheckBoxChecked;
        private FormattedAddress selectedAddress;

        private SettingsCommand okCommand;

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
                if (text != SelectedAddress?.ToString())
                    OnPropertyChanged();
            }
        }

        public ICommand OkCommand
        {
            get
            {
                if (okCommand == null)
                    okCommand = new SettingsCommand(SetConfig, CanSetConfig);
                return okCommand;
            }
        }

        private bool CanSetConfig(object parametr)
        {
            if (selectedAddress == null)
                return false;
            return true;
        }

        private void SetConfig(object parameter)
        {
            configEditor.SetLoaction(selectedAddress.Location);
        }

        public bool IsCheckBoxChecked
        {
            get
            {
                return isCheckBoxChecked;
            }

            set
            {
                isCheckBoxChecked = value;
                IsEnableComboBox = !value;
                OnPropertyChanged();
            }
        }

        public bool IsEnableComboBox
        {
            get
            {
                return isEnableComboBox;
            }

            set
            {
                isEnableComboBox = value;
                OnPropertyChanged();
            }
        }

        public FormattedAddress SelectedAddress
        {
            get
            {
                return selectedAddress;
            }

            set
            {
                selectedAddress = value;
                OnPropertyChanged();
            }
        }

        public IList<FormattedAddress> Addresses
        {
            get
            {
                return addresses;
            }

            private set
            {
                addresses = value;
                OnPropertyChanged();
            }
        }

        public bool IsDropDownOpen
        {
            get
            {
                return isDropDownOpen;
            }

            set
            {
                isDropDownOpen = value;
                OnPropertyChanged();
            }
        }


        public SettingsViewModel(IGeocodingService geocodingService)
        {
            this.geocodingService = geocodingService;
            //var location = configEditor.GetLoaction();
            //if (location != null)
                IsCheckBoxChecked = true;
        }

        private async void GetNewAddresses(string address)
        {
            if (string.IsNullOrEmpty(address))
                return;
            try
            {
                var addresses = await geocodingService.GetFormattedAddressAsync(address);
                Addresses = addresses.Where(addres => !string.IsNullOrEmpty(addres.CityName) || !string.IsNullOrEmpty(addres.Town)).ToList();
                IsDropDownOpen = true;
            }
            catch (WeatherApp.Services.LocationIQGeocodingException e)
            {
                messegeBoxService.ShowMessege(e.Message);
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (propertyName == nameof(Text))
                GetNewAddresses(text);
        }
    }
}
