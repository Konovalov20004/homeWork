int size = enterSize("Введите колличество элементов в массиве");
double[] x = new double[size];
double s = fillingArray(size);
Console.WriteLine($"Разница между большим и меньшим элементом равна: {searchDifference(size)}");
foreach (double a in x){
    Console.Write($"{a} ");
}

int enterSize(string message) {
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double fillingArray(int size) {
    Random random = new Random();
    int a = 0;
    for (int c = 0; c < size; c++) {
        double v = Math.Round((random.NextDouble()*100d), 2);
        x[c] = v;
    } return a;
}

double searchDifference (int size) {
    double max = x[0];
    double min = max;
    foreach (int a in x){
        if (a > max) max = a;
        if (a < min) min = a;
    }
    double difference = max - min;
    return difference;
}
