This project uses the following nuggets 

* Microsoft.Extensions.AI
* Microsoft.Extensions.AI.OpenAI
* OllamaSharp *(previously Microsoft.Extensions.AI.Ollama)*

## Configuration
This goes into appsettings.Development.json

~~~ json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "AiConfig": {
    "ApiKey": "sk-key-here",
    "Provider": "OpenAI",
    "Endpoint": "",
    "Model": "gpt-5-nano"
  }
}
~~~ bash
