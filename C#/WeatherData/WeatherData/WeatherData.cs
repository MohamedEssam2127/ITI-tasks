using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace WeatherDataOP

{
    public  class WeatherData
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        public event Action<float, float, float> OnMeasurementsChanged;

        

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            OnMeasurementsChanged?.Invoke(_temperature, _humidity, _pressure);
        }


    }

    public interface IDisplayElement
    {
        string Display();
    }


    public class CurrentConditionsDisplay :  IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            weatherData.OnMeasurementsChanged += Update;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            Display();
        }

        public string Display()
        {
            return $"Current conditions: {_temperature}F degrees and {_humidity}% humidity";
        }
    }

    public class ForecastDisplay : IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;

        public ForecastDisplay(WeatherData weatherData)
        {
            weatherData.OnMeasurementsChanged += Update;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        public string Display()
        {
            string res = "Forecast: ";
            if (_currentPressure > _lastPressure) res +="Improving weather on the way!";
            else if (_currentPressure == _lastPressure) res += ("More of the same");
            else if (_currentPressure < _lastPressure) res += ("Watch out for cooler, rainy weather");
            return res;
        }
    }

    public class HeatIndexDisplay : IDisplayElement
    {
        private float _heatIndex = 0.0f;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            weatherData.OnMeasurementsChanged += Update;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _heatIndex = ComputeHeatIndex(temperature, humidity);
            Display();
        }

        private float ComputeHeatIndex(float t, float rh)
        {
            return (float)((16.923 + (0.185212 * t)) +
                (5.37941 * rh) - (0.100254 * t * rh) +
                (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) + 
                (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) 
                + (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) +
                (0.0000291583 * (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) 
                + (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh))
                + (0.000000000843296 * (t * t * rh * rh * rh)) - (0.0000000000481975 * (t * t * t * rh * rh * rh)));
        }

        public string Display()
        {
            return $"Heat index is {_heatIndex:F2}";
        }
    }

    public class StatisticsDisplay : IDisplayElement
    {
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;

        public StatisticsDisplay(WeatherData weatherData)
        {
            weatherData.OnMeasurementsChanged += Update;
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _tempSum += temperature;
            _numReadings++;
            if (temperature > _maxTemp) _maxTemp = temperature;
            if (temperature < _minTemp) _minTemp = temperature;
            Display();
        }

        public string Display()
        {
            float avg = _numReadings > 0 ? (_tempSum / _numReadings) : 0;
            return $"Avg/Max/Min temperature = {avg:F1}/{_maxTemp}/{_minTemp}";
        }
    }
}
