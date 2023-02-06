int[] sizeArray = new int[2];

for (int x = 0; x < 2; x++) {
    string[] y = {"Line", "Column"};
    Console.Write($"Number of {y[x]}> ");
    sizeArray[x] = Convert.ToInt32(Console.ReadLine());
}

decimal[,] a = new decimal[sizeArray[0],sizeArray[1]];

Random random = new Random();
for (int y = 0; y < sizeArray[0]; y++) {
    for (int x = 0; x < sizeArray[1]; x++) {
        int rnd = random.Next(0,2); 
        double temporary = random.NextDouble()*10;
        decimal values = Convert.ToDecimal(Math.Round(temporary, 1));
        if (rnd == 0) values *= -1;
        a[y, x] = values;
    }
}

for (int x = 0; x < sizeArray[0]; x++) {
    for (int y = 0; y < sizeArray[1]; y++){
        Console.Write(a[x, y] +"\t");
    }
Console.Write("\n");
}