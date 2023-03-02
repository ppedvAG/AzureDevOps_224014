// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using System.Reflection;

Console.WriteLine("Hello, World!");


var PWD = "SehrGeheimePasswort"; //Secrets im Code sind doof
Console.WriteLine($"Password aus Code == DOOF: {PWD}");

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                       .AddUserSecrets(Assembly.GetExecutingAssembly())
                                       .Build();

var sec = config.GetSection("Password");
Console.WriteLine($"Password aus appsettings: {sec.Value}");


Console.WriteLine("Ende");
Console.ReadKey();