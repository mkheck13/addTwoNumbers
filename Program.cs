
Console.Clear();

Console.WriteLine("num1");

string? num1 = Console.ReadLine();

Console.WriteLine("num2");

string? num2 = Console.ReadLine();

int num1Con = Convert.ToInt32(num1);
int num2Con = Convert.ToInt32(num2);
int sum = num1Con + num2Con;

Console.WriteLine($"so {num1Con} plus {num2Con} equals {sum}");

