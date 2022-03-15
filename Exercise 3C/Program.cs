
{
    int a, b, c, perimeter, s, area;

    Console.WriteLine("\nPlease Enter three sides of triangle\n");
   a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
    perimeter = a + b + c;
    s = Convert.ToInt32(a + b + c) / 2;
    area = (s * (s - a) * (s - b) * (s - c));

    Console.WriteLine($" Area of the triangle: {area}");

    return 0;
}