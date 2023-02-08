Console.Write($"Введите число N: ");
int namberN = Convert.ToInt32(Console.ReadLine());

double cube = 1;
int count = 1;

while (count < namberN + 1)
{
	cube = Math.Pow(count, 3);
	System.Console.WriteLine(cube);
	count++;
}