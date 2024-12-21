using OmniJournal;

namespace OmniJournal.Api;
public static partial class Api
{
    public static void SetUpApiSample(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/health", () => new { Status = "Healthy" })
            .WithName("GetHealth");

        app.MapGet("/api/echo", (string message) => new { Message = message })
            .WithName("GetEcho");

        app.MapGet("/api/echo/{message}", (string message) => new { Message = message })
            .WithName("GetEchoMessage");

        app.MapGet("/api/echo/{message}/{count:int}", (string message, int count) =>
        {
            var messages = Enumerable.Range(1, count).Select(i => message).ToArray();
            return new { Messages = messages };
        })
        .WithName("GetEchoMessageCount");

        app.MapGet("/api/echo/{message}/{count:int}/{delay:int}", async (string message, int count, int delay) =>
        {
            var messages = Enumerable.Range(1, count).Select(i => message).ToArray();
            await Task.Delay(delay);
            return new { Messages = messages };
        })
        .WithName("GetEchoMessageCountDelay");

        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        app.MapGet("/api/weatherforecast", () =>
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = summaries[Random.Shared.Next(summaries.Length)]
                })
                .ToArray();

            return forecast;
        })
        .WithName("GetWeatherForecastMinimal");

        app.MapGet("/api/echo/{message}/{count:int}", (string message, int count) =>
        {
            var messages = Enumerable.Range(1, count).Select(i => message).ToArray();
            return new { Messages = messages };
        })
        .WithName("TestFactory");
    }
}
