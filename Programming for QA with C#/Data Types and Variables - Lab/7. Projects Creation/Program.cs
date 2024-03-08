using System.Runtime.InteropServices;

string nameOfArchitect = Console.ReadLine();
int numberOfProjects = int.Parse(Console.ReadLine());

int hoursNeededForProjectCreation = numberOfProjects * 3;

Console.WriteLine($"The architect {nameOfArchitect} will need {hoursNeededForProjectCreation} hours to complete {numberOfProjects} project/s.");