using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WeatherApp.WP8.Resources;

namespace WeatherApp.WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 建構函式
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                locationText.Text = weather.Title;
                tempText.Text = weather.Temperature;
                windText.Text = weather.Wind;
                visibilityText.Text = weather.Visibility;
                humidityText.Text = weather.Humidity;
                sunriseText.Text = weather.Sunrise;
                sunsetText.Text = weather.Sunset;

                weatherBtn.Content = "Search Again";
            }
        }
    }
}