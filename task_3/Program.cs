Console.Clear();
Console.Write("Введите число ");
int count = 0;
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    count = number*(-1);
        while (count <= number)
        {
            Console.Write($"{count}, ");
        count++;   
        }
}
else
{
    count = number;
    while (count <=number*(-1))
    {
        
    }
}