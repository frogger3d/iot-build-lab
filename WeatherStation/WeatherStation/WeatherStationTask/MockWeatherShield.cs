using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationTask.Sparkfun;
using Windows.Devices.Gpio;
using Windows.Foundation;

namespace WeatherStationTask
{
    class MockWeatherShield : IWeatherShield
    {
        private const int STATUS_LED_BLUE_PIN = 6;
        private const int STATUS_LED_GREEN_PIN = 5;
        private Random random = new Random();

        public MockWeatherShield()
        {
            this.BlueLEDPin = GpioController.GetDefault().OpenPin(STATUS_LED_BLUE_PIN);
            this.GreenLEDPin = GpioController.GetDefault().OpenPin(STATUS_LED_GREEN_PIN);
        }
        
        public GpioPin BlueLEDPin { get; private set; }

        public GpioPin GreenLEDPin { get; private set; }

        public float Altitude
        {
            get { return random.Next(200); }
        }

        public float Humidity
        {
            get { return random.Next(200); }
        }

        public float Pressure
        {
            get { return random.Next(200); }
        }

        public float Temperature
        {
            get { return random.Next(200); }
        }

        public IAsyncAction BeginAsync()
        {
            return Task.FromResult(true).AsAsyncAction();
        }
    }
}
