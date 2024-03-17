int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

bool isIdentical = true;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] != array2[i])
    {
        isIdentical = false;
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}