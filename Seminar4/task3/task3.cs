/*int enter (string message){
    Console.WriteLine($"Введити числа без пробелов > ");
    return Convert.ToInt32(Console.ReadLine());
}

int length (int a){
    a = ;
    for (int c = 0; b != 0;c++){
        a /=10 ;
    }
    return(a);
}
*/

int length = Convert.ToInt32(Console.ReadLine());
int enter = Convert.ToInt32(Console.ReadLine());
int[] x = new int[length];
for (int i = 0; i < length; i++){
    x[i] = fillingAr(enter);
}
int fillingAr (int a){
    int v = enter % 10;;
    enter /= 10;
    return(v);  
}

foreach (int s in x){
    Console.Write(s);
}