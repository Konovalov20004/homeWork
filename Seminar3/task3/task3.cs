Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"{a} ->");
int y = 0;
for (int x = 0; x < a; x++) {
	y++;
	Console.Write(" " + Math.Pow(y,3));
}
