Console.Write($"Введите 5-ти значное число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int[] array = new int [5]; 
int index = 4;

while (index > -1)
{
	array[index] = namber % 10;
	namber = namber / 10;
	index--;
}

if (array[0] == array[4] && array[1] == array[3])
{
	System.Console.WriteLine("Это число является палиндромом");
}
else 
{
	System.Console.WriteLine("Это число не является палиндромом");
}