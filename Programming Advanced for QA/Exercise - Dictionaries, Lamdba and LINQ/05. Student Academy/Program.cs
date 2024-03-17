using System.Xml.Linq;

var studentsAndGrades = new Dictionary<string, List<double>>();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string student = Console.ReadLine();    
    double grade = double.Parse(Console.ReadLine());

    if (studentsAndGrades.ContainsKey(student))
    {
        studentsAndGrades[student].Add(grade);
    }
    else
    {
        studentsAndGrades.Add(student, new List<double> { grade });
    }
}

foreach (var pair in  studentsAndGrades)
{
    string student = pair.Key;
    double averageGrade = pair.Value.Average();
    if (averageGrade >= 4.50)
    {
        Console.WriteLine($"{student} -> {averageGrade:F2}");
    }
}