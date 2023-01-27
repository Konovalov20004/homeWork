int entere (string message){
    Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int enter = entere("Введите числа без пробелов");
int longa = length(enter);
int[] x = new int[longa];

for ( int b = 0; longa > b; b++){
    int q = fillingAr(longa);
    x[b] = q;
}
Array.Reverse(x);
foreach (int s in x){
    Console.Write(s);
}


int length (int a){
    a = enter;
    int count = 0;
    for (int c = 0; a != 0;c++){
        a /=10 ;
        count++;
    }
    return(count);
}


//int length = Convert.ToInt32(Console.ReadLine());

int number = enter;
int fillingAr (int a){
    a = longa;
    //for (int o = 0; o < a; o++){
        int v = enter % 10;;
        enter /= 10;
        a--;
        return(v);  
    //}
}

for ( int b = 0; longa > b; b++){
    int q = fillingAr(longa);
    x[b] = q;
}
