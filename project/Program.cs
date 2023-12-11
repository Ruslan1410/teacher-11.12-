Console.WriteLine("Enter number A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter type of operation: ");
string sum = Console.ReadLine();

if(sum == "/")
{
    Console.WriteLine(a / b);
}
else if(sum == "+")
{
    Console.WriteLine(a + b);
}

else if(sum == "-")
{
    Console.WriteLine(a - b);
}
else if(sum == "*")
{
    Console.WriteLine(a * b);
}
else
Console.WriteLine("you entered an incorrect value");
