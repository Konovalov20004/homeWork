decimal[] coordinates = new decimal[4];
string[] namePunkt = {"b1", "k1", "b2", "k2"};
string[] numberLine = {"первой", "второй"};
int count = 0;
for (int c = 0; c < 2; c++){
    Console.WriteLine($"Координаты {numberLine[c]} прямой: ");
    for (int v = 0; v < 2; v++) {
        Console.Write($"Введите точку {namePunkt[count]} >");
        coordinates[count] = Convert.ToDecimal(Console.ReadLine());
        count++;
    }

decimal x = 0;
decimal y = 0;
if (coordinates[1] - coordinates[3] == 0 && -coordinates[0] + coordinates[2] == 0) {
    Console.WriteLine($"\n Ваши прямые совпадают");
} else if (coordinates[1] - coordinates[3] == 0 || -coordinates[0] + coordinates[2] == 0) {
        Console.WriteLine($"\n Ваши прямые не пересекаются");
    } else {
        x =(-coordinates[0] + coordinates[2])/(coordinates[1] - coordinates[3]);
        y = coordinates[3] * x + coordinates[2];}
Console.WriteLine($"Координаты пересечения заданных прямых: {x};{y}");