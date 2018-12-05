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
        private bool isDropDownOpen;
        private bool isEnableComboBox;
        private bool isCheckBoxChecked;
        private FormattedAddress selectedAddress;

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
            get { return isDropDownOpen; }
            set
            {
                isDropDownOpen = value;
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
            IsDropDownOpen = true;
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
