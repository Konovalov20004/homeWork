int[] sizeArray = new int[2];
for (int a = 0; a < 2; a++) {
    string[] name = {"Line", "Column"};
    Console.WriteLine($"Enter number {name[a]}");
    sizeArray[a] = Convert.ToInt32(Console.ReadLine());
}

int[,,] x = new int[sizeArray[0], sizeArray[1], 2];
int count = 1;
Random random = new Random();
for (int a = 0; a < sizeArray[0]; a++){
    for (int b = 0; b < sizeArray[1]; b++){
        int value = random.Next(101);
        x[a, b, 0]= value;
    }
}
for (int a = 0; a < sizeArray[0]; a++){
    for (int b = 0; b < sizeArray[1]; b++){
        x[a, b, 1] = count;
        count++;
    }
}
for (int a = 0; a < sizeArray[0]; a++) {
    for (int b = 0; b < sizeArray[1]; b++){
        Console.Write(x[a, b, 0] +"\t");
    }
Console.Write("\n");
}
Console.WriteLine("Enter number element array");
int numberElement = Convert.ToInt32(Console.ReadLine());
int c = 0;
int cc = 0;
//if (numberElement > x[sizeArray[0]-1, sizeArray[1]-1, 1]/2)
//Была идея немного ускорить поиск нужного элемента, но передумал, потому что пока что работа с небольшими массивами.
for (int a = 0; a < sizeArray[0]; a++){
    c = a;
    for (int b = 0; b < sizeArray[1]; b++){
        cc = b;
        if (numberElement == x[a, b, 1]) break;
    }
    if (numberElement == x[a, cc, 1]) break;
} 

if (numberElement > sizeArray[0] * sizeArray[1]) {
    Console.WriteLine("No Such element");
} else {
    Console.WriteLine(x[c, cc, 0]);
}