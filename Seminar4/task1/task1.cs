int textInput (string message) {
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int AdegreeB (int a, int b) {
    int degree = 1;
    for (int x = 0; x < b; x++) {
        degree *= a;
    }
    return degree;
}

int A = textInput("Введите число, которое хотите возвести в степень");
int B = textInput("Введите число, в какую степень хотите возвести в степень");
int result = AdegreeB(A, B);
Console.WriteLine($"Получается: {result}");