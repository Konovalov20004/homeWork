Console.Write("Введите числа через пробел > ");
string[] a = Console.ReadLine().Split(" ");
int[] b = new int[a.Length];
int count = 0;
for (int c = 0; c < a.Length; c++) {
    b[c] = Convert.ToInt32(a[c]);}
for (int c = 0; c < b.Length; c++){
        if (b[c] > 0) count++;}
Console.WriteLine($"Количество натуральных чисел: {count}");