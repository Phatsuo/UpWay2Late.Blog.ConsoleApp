using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace UpWay2Late.Blog.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var world = config["world"];

            Console.WriteLine($"Hello {world}!");

            Console.ReadLine();
        }
    }
}
