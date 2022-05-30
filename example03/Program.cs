// программа для копирования массива
Console.Clear();
Console.Write("Введите желаемую длину массива: ");
int l = int.Parse(Console.ReadLine()??"");

int[] array = new int[l];
Random rnd = new Random();

int[] array2 = new int[l];

for (int i = 0; i < l; i++)
	array[i] = rnd.Next(-1000, 1000);
int count = 1;
int count2 = 1;
foreach (int a in array)
{
	Console.WriteLine($"{count} элемент массива = {a}");
	count++;
}
for (int i = 0; i < l; i++)
	array2[i] = array[i];
foreach (int b in array2)
{
	Console.WriteLine($"{count2} элемент массива 2 = {b}");
	count2++;
}