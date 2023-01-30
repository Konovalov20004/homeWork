int size = enterSize("Введите размер массива, или измените код, чтобы размер массива определялся случайно"); 
int[] result = new int[size];
int filling = fillingRandom(size);
Console.Write($"Массив имеет такие числа:\n");

int enterSize (string message){
    Console.Write($"{message} >: ");
    return Convert.ToInt32(Console.ReadLine());
}

int sizeRandom (){
    Random size = new Random();
    int x = size.Next(10);
    return x;
}

int fillingRandom(int size){
    Random random = new Random();
    int ret = random.Next(1);
    for (int x = 0; x < size; x++){
        int b = random.Next(99, 999);
        result[x] = b;
    } return ret;
}

int searchOdd (int x){
    int count = 0;
        foreach(int a in result){
        if (a % 2 == 0) count++; 
    } return count;
}

foreach(int x in result){
    Console.Write($"{x} ");
}
Console.Write($" :<{searchOdd(1)} чётных чисел");