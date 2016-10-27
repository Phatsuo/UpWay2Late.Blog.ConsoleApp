using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;

namespace UpWay2Late.Blog.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        public static async Task MainAsync(string[] args)
        {
            await RunApplicationAsync(args);
            
            Console.ReadLine();
        }

        /// <summary>
        /// Runs the application asynchronously.
        /// </summary>
        private static async Task RunApplicationAsync(string[] args)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var world = config["world"];

            await DoSomethingAsync();

            var commandLineApplication = new CommandLineApplication
            {
                Name = "UpWay2Late.Blog.ConsoleApp.exe",
                Description = "Sample app that can say hello or goodbye!",
                FullName = ".NET Core Console App"
            };

            commandLineApplication.Command("hello", c =>
            {
                c.Description = "Says hello.";
                c.OnExecute(() =>
                {
                    Console.WriteLine($"Hello {world}!");
                    return 0;
                });
            });

            commandLineApplication.Command("goodbye", c =>
            {
                c.Description = "Says goodbye.";
                c.OnExecute(() =>
                {
                    Console.WriteLine($"Goodbye {world}!");
                    return 0;
                });
            });

            commandLineApplication.OnExecute(() =>
            {
                commandLineApplication.ShowHelp();
                return 2;
            });

            commandLineApplication.Execute(args);
        }

        /// <summary>
        /// Async method to call for demonstration purposes only.
        /// </summary>
        private static async Task DoSomethingAsync()
        {
            await Task.Delay(1);
        }
    }
}
