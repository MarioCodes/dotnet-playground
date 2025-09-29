using llms.Configuration;
using llms.Services;
using llms.Services.interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OpenAI;
using System;

namespace llms
{
    public class Startup
    {

        public IConfiguration _config { get; }

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Custom Configurations
            services.Configure<AiConfig>(_config.GetSection(AiConfig.Section));

            // this instantiates an IChatClient based on the AiOptions configuration
            services.AddSingleton<IChatClient>(sp =>
            {
                var config = sp.GetRequiredService<IOptions<AiConfig>>().Value;
                return CreateChatClientFrom(config);
            });

            // services
            services.AddSingleton<ITextGen, TextGen>();
        }

        // this pattern lets you run locally Ollama for development, then flip to OpenAI in production by changing config only
        private IChatClient CreateChatClientFrom(AiConfig config)
        {
            return config.Provider switch
            {
                "OpenAI" => CreateOpenAIClient(config),
                "Ollama" => /* create IChatClient using Ollama provider */ throw new NotImplementedException(),
                _ => throw new InvalidOperationException($"The AI provider '{config.Provider}' is not supported"),
            };
        }

        private IChatClient CreateOpenAIClient(AiConfig config)
        {
            string openAiKey = config.ApiKey ?? throw new InvalidOperationException("OpenAI API key is not configured");
            string model = config.Model ?? throw new InvalidOperationException("OpenAI model is not configured");
            IChatClient chatClient = new OpenAIClient(openAiKey)
                .GetChatClient(model)
                .AsIChatClient();
            return chatClient;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
