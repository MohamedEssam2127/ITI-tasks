
using WeatherDataOP;

namespace UI
{
    public partial class Form1 : Form
    {

        private WeatherData weatherData;
        private CurrentConditionsDisplay currentDisplay;
        private StatisticsDisplay statisticsDisplay;
        private ForecastDisplay forecastDisplay;
        private HeatIndexDisplay heatIndexDisplay;
        public Form1()
        {
            InitializeComponent();
            weatherData = new WeatherData();

            currentDisplay = new CurrentConditionsDisplay(weatherData);
            statisticsDisplay = new StatisticsDisplay(weatherData);
            forecastDisplay = new ForecastDisplay(weatherData);
            heatIndexDisplay = new HeatIndexDisplay(weatherData);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isTempValid = float.TryParse(txtTemperature.Text, out float temp);
            bool isHumValid = float.TryParse(txtHumidity.Text, out float hum);
            bool isPressValid = float.TryParse(txtPressure.Text, out float press);

            if (isTempValid && isHumValid && isPressValid)
            {
                weatherData.SetMeasurements(temp, hum, press);
                lblCurrentDisplay.Text = currentDisplay.Display();
                lblForecastDisplay.Text = forecastDisplay.Display();
                lblStatsDisplay.Text = statisticsDisplay.Display();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
