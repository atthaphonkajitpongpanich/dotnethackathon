namespace WebApi.Tests;

public class WeatherForecastTests
{
    [Theory]
    [InlineData(0, 32)]      // 0°C = 32°F
    [InlineData(20, 68)]     // 20°C = 68°F
    [InlineData(-10, 14)]    // -10°C = 14°F
    [InlineData(30, 86)]     // 30°C = 86°F
    [InlineData(100, 212)]   // 100°C = 212°F
    public void TemperatureF_ConvertsCorrectly(int temperatureC, int expectedF)
    {
        // Arrange
        var date = DateOnly.FromDateTime(DateTime.Now.AddDays(1));
        var forecast = new WeatherForecast(date, temperatureC, "Test");

        // Act
        var actualF = forecast.TemperatureF;

        // Assert
        Assert.Equal(expectedF, actualF);
    }

    [Fact]
    public void WeatherForecast_CanBeCreated()
    {
        // Arrange
        var date = new DateOnly(2023, 12, 25);
        var temperatureC = 15;
        var summary = "Mild";

        // Act
        var forecast = new WeatherForecast(date, temperatureC, summary);

        // Assert
        Assert.Equal(date, forecast.Date);
        Assert.Equal(temperatureC, forecast.TemperatureC);
        Assert.Equal(summary, forecast.Summary);
    }

    [Fact]
    public void WeatherForecast_CanHaveNullSummary()
    {
        // Arrange
        var date = new DateOnly(2023, 12, 25);
        var temperatureC = 15;

        // Act
        var forecast = new WeatherForecast(date, temperatureC, null);

        // Assert
        Assert.Equal(date, forecast.Date);
        Assert.Equal(temperatureC, forecast.TemperatureC);
        Assert.Null(forecast.Summary);
    }
}