
Start();
void Start()
{

   
    int a = GetNumber("Enter number A: ");
    int b = GetNumber("Enter number B: ");

    string sum = Sum("Enter type of operation: ");

    int summ = operation(a,b,sum);
    Console.WriteLine(summ);
}
    
int GetNumber(string text)
{
    Console.Write(text);
    int i = int.Parse(Console.ReadLine());
    return i;
}

string Sum(string text)
{
    Console.Write(text);
    string sum = Console.ReadLine();
    return sum;
}

int operation(int a, int b, string sum)
{
    if(sum == "/")
    {
       return a / b;
    }
    else if(sum == "+")
    {
        return a + b;
    }
    else if(sum == "-")
    {
        return a - b;
    }
    else if(sum == "*")
    {
       return a * b;
    }
    else
    {
        
       return 0;
    }
}
