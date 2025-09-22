using OpenAI;
using Microsoft.Extensions.AI;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace llms
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // using user secrets to store the OpenAI key
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddUserSecrets<Program>();
            string openAiKey = builder.Configuration["OpenAI:ApiKey"];

            IChatClient chatClient = new OpenAIClient(openAiKey)
                .GetChatClient("gpt-5-nano")
                .AsIChatClient();
            string question = "Dime una feature de c# que me puede ser util en mi carrera y que igual no conozco. Como mucho 1-2 lineas. Solo quiero que me des lo minimo y necesario y yo con eso exploraré a más en detalle.";
            var response = await chatClient.GetResponseAsync(question);

            foreach(var message in response.Messages)
            {
                Console.WriteLine(message);
            }
        }

    }
}
