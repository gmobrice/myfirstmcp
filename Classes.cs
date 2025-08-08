using System.ComponentModel;
using ModelContextProtocol.Server;

[McpServerToolType]
public static class EchoTool
{
  [McpServerTool, Description("Echoes the message back to the client.")]
  public static string Echo(string message) => $"Hello from C#: {message}";

  [McpServerTool, Description("Echoes the reversed message back to the client.")]
  public static string ReverseEcho(string message) => new string(message.Reverse().ToArray());

  [McpServerTool, Description("Returns a random city name from a predefined list.")]
  public static string GetRandomCity()
  {
    var cities = new[] { "Barcelona", "Berlin", "New York", "Tokyo", "Sydney", "Paris" };
    var random = new Random();
    return cities[random.Next(cities.Length)];
  }

  [McpServerTool, Description("Returns a random city from the list of cities provided.")]
  public static string GetRandomCityFromList(string[] cities)
  {
    if (cities == null || cities.Length == 0)
      return "No cities provided";
      
    var random = new Random();
    return cities[random.Next(cities.Length)];
  }
}