int size = enterSize("Введите размер массива");
int[] workingArray = new int[size];
int filling = fillingArray(size);
foreach (int x in workingArray) {
    Console.Write($"{x} ");
}
Console.WriteLine($"\nСумма чисел на нечётных позициях = {sumOdd(size)}");

int enterSize (string message) {
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int fillingArray (int size) {
    Random random = new Random();
    int v = random.Next (1);
    for (int c = 0; c < size; c++) {
        int number = random.Next(-100, 100);
        workingArray[c] = number;        
    } return v;
}

int sumOdd (int size) {
    int sum = 0;
    for (int c = 1; c < size; c += 2) {
        sum = sum + workingArray[c];
    } return sum;
}