Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int a = number;
decimal count = number;
int i = 0;
int result = 0;
while (count  > 1) {
	count = count / 10;
	i++;
} 
if (i >= 3){
	for (int x = i; x > 3; x--){
	a = a / 10;
}
result = a % 10;
Console.WriteLine($"Третья цифра введённого числа: {result}");
} else {
Console.WriteLine("Вы ввели двухзначное число, введите трехзначное");
};
