int athlete1Time = int.Parse(Console.ReadLine());
int athlete2Time = int.Parse(Console.ReadLine());
int athlete3Time = int.Parse(Console.ReadLine());

int totalTime = athlete1Time + athlete2Time + athlete3Time;
int timeMinutes = totalTime / 60;
int  timeSeconds = totalTime % 60;
 
if  (timeSeconds < 10)
{
    Console.WriteLine($"{timeMinutes}:0{timeSeconds}");
}
else
{
    Console.WriteLine($"{timeMinutes}:{timeSeconds}");
}