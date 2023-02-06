int[] sizeArray = new int[2];
for (int a = 0; a < 2; a++) {
    string[] name = {"Line", "Column"};
    Console.WriteLine($"Enter {name[a]}");
    sizeArray[a] = Convert.ToInt32(Console.ReadLine());
}
int[,] randomArray = new int[sizeArray[0], sizeArray[1]];
Random random = new Random();
for (int a = 0; a < sizeArray[0]; a++) {
    for (int b = 0; b < sizeArray[1]; b++) {
        int x = random.Next(100);
        randomArray[a, b] = x;
    }
}

for (int a = 0; a < sizeArray[0]; a++) {
    for (int b = 0; b < sizeArray[1]; b++) {
        Console.Write($"{randomArray[a, b]}\t");
    } Console.Write("\n");
}

decimal arethmeticMeanColumn = Convert.ToDecimal(sizeArray[1]);
Console.WriteLine("Arethmetic mean colum:");
for (int b = 0; b < sizeArray[1]; b++){
    int sum = 0;
    for (int a = 0; a < sizeArray[0]; a++){
        sum += randomArray[a, b];
    } Console.Write(sum/arethmeticMeanColumn + "\t");
}