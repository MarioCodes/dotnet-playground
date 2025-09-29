namespace llms.Configuration
{
    public class AiConfig
    {
        public const string Section = "AiConfig";
        public string? Provider { get; set; } // OpenAI | Ollama
        public string? Endpoint { get; set; }
        public string? ApiKey { get; set; }
        public string? Model { get; set; } // gpt-5-nano
    }
}
