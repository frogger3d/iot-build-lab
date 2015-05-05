using System.Threading.Tasks;
using Windows.Devices.Gpio;
using Windows.Foundation;

namespace WeatherStationTask
{
    public interface IWeatherShield
    {
        /// <summary>
        /// Blue status LED on shield
        /// </summary>
        /// <remarks>
        /// This object will be created in InitAsync(). The set method will
        /// be marked private, because the object itself will not change, only
        /// the value it drives to the pin.
        /// </remarks>
        GpioPin BlueLEDPin { get; }

        /// <summary>
        /// Green status LED on shield
        /// </summary>
        /// <remarks>
        /// This object will be created in InitAsync(). The set method will
        /// be marked private, because the object itself will not change, only
        /// the value it drives to the pin.
        /// </remarks>
        GpioPin GreenLEDPin { get; }

        /// <summary>
        /// Read altitude data
        /// </summary>
        /// <returns>
        /// Calculates the altitude in meters (m) using the US Standard Atmosphere 1976 (NASA) formula
        /// </returns>
        float Altitude { get; }
        
        /// <summary>
        /// Calculate relative humidity
        /// </summary>
        /// <returns>
        /// The relative humidity
        /// </returns>
        float Humidity { get; }

        /// <summary>
        /// Read pressure data
        /// </summary>
        /// <returns>
        /// The pressure in Pascals (Pa)
        /// </returns>
        float Pressure { get; }

        /// <summary>
        /// Calculate current temperature
        /// </summary>
        /// <returns>
        /// The temperature in Celcius (C)
        /// </returns>
        float Temperature { get; }

        /// <summary>
        /// Initialize the Sparkfun Weather Shield
        /// </summary>
        /// <remarks>
        /// Setup and instantiate the I2C device objects for the HTDU21D and the MPL3115A2
        /// and initialize the blue and green status LEDs.
        /// </remarks>
        IAsyncAction BeginAsync();
    }
}