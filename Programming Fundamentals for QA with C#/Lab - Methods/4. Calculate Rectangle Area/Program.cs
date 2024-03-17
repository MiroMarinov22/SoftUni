int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

Console.WriteLine(GetRectangleArea(width, length));
static int GetRectangleArea(int wid, int len)
{
    int area = wid * len;
    return area;
}