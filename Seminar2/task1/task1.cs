Console.WriteLine("Введите число");
int numbers = Convert.ToInt32(Console.ReadLine());
char[] value = numbers.ToString().ToCharArray();
Console.WriteLine($"Вывод второй цифры {value[1]}");