int enter (string message){
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int sumNumber (int n) {
    int sum = 0;
    int x = n;
    for (int i = 0; x != i;) {
        int c = x % 10;
        sum += c;
        x /= 10;
    }
    return(sum);
}

int number = enter("Введите число, чтобы узнать сумму цифр");
int sum = sumNumber(number);
Console.WriteLine(sum);