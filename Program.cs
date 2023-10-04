// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

foreach(Process process in Process.GetProcesses())
{
    Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
}