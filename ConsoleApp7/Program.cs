Console.WriteLine("Please write the numbers with a space");
string a = Console.ReadLine();

string[] b = a.Split(' ');

int[] numbers = b.Select(int.Parse).ToArray();

Console.WriteLine("Please write Target Number");
int T = int.Parse(Console.ReadLine());

Console.WriteLine(calculate(numbers));

string calculate(int[] num1)
{
    for (int i = 0; i < num1.Length; i++)
    {
        for (int j = 0; j < num1.Length; j++)
        {
            if (num1[i] + num1[j] == T)
            {
                return $"{numbers[i]} +  {numbers[j]} =  {T}";
            }
        }
    }
    return "";
}

Console.ReadKey();
