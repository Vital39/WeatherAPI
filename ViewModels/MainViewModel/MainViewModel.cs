using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessModels;
using WeatherApp.Commands;
using WeatherApp.Interfaces;
using WeatherApp.Services.DarkSkyWeatherService;

namespace WeatherApp.ViewModels.MainViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IWeatherService weatherService;
        private BusinessWeatherForecastFactory factory = new BusinessWeatherForecastFactory();
        public event PropertyChangedEventHandler PropertyChanged;
        private BusinessWeatherForecast forecast;
        private SettingsCommand command;

        //public SettingsCommand Command  
        //{
        //    get
        //    {
        //        if (command == null)
        //            command = new SettingsCommand();
        //        return command;
        //    }
        //    set
        //    {
        //        command = value;
        //    }
        //}


        public BusinessWeatherForecast Forecast
        {
            get { return forecast; }
            set
            {
                forecast = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            weatherService = new DarkSkyWeatherService();
            UpdateForecast();
        }

        private async void UpdateForecast()
        {
            var _forecast =  await weatherService.GetWeather();
            Forecast = factory.Make(_forecast);
            
        }
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
