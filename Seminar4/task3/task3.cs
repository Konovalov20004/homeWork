int[] x = new int[8];
for (int i = 0; i < 8; i++) {
    x[i] = y();
}

int y (){
    Console.WriteLine("Введите число");
    int v = Convert.ToInt32(Console.ReadLine());
    return v;
}

foreach (int a in x){
    Console.Write($"{a} ");
}