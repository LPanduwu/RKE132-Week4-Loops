int sum = 0;
for (int i = 1; i < 11; i++) //i-- = i - 1
{
    Console.WriteLine($"i = {i}");
    sum += i; //sum = sum + i;
    Console.WriteLine($"Current total: {sum}");
}
Console.WriteLine($"Final total: {sum}");