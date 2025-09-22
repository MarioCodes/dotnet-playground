using Microsoft.Extensions.AI;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using llms.Services.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace llms
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            ITextGen gen = host.Services.GetRequiredService<ITextGen>();
            string question = "Dime una feature de c# que me puede ser util en mi carrera y que igual no conozco. Como mucho 1-2 lineas. Solo quiero que me des lo minimo y necesario y yo con eso exploraré a más en detalle.";
            Console.WriteLine($"question: {question} \n");

            string response = await gen.CompleteAsync(question);
            Console.WriteLine($"response: {response}");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
