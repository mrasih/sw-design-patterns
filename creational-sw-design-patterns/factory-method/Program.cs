// See https://aka.ms/new-console-template for more information
using System.Collections;
using FactoryMethod;

Console.WriteLine("Hello, World!");

ArrayList workplaces = new();
workplaces.Add(new SoftwareCompany());
workplaces.Add(new Factory());

foreach (Workplace workplace in workplaces)
{
    Console.WriteLine("\n" + workplace.GetType().Name);
    foreach (IWorker worker in workplace.GetWorkers())
    {
        Console.WriteLine($"- {worker.GetType().Name}: {worker.Work()}");
    }
}