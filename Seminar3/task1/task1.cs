Console.WriteLine("Введите число");
//Здесь работа с массивами и преобразование типов данных
int number = Convert.ToInt32(Console.ReadLine());
char[] x = number.ToString().ToCharArray();
int[] y  = new int[x.Length];
int v = 0;
int u = 0;

foreach (int a in x){
    v = a - 48;
    y[u] = v;
    u++;
} 
//Здесь проверка на палиндром
int i = y.Length;
int t = i / 2;
int r = 0;
int c = i;

if ( i > 1) {
    for (int o = 0; o < i / 2; o++){
        c--;
        if ( y[o] == y[c]) {
            r++;
        }
    } if ( r == t) {
        Console.WriteLine("Ваше число палиндромом");
    } else Console.WriteLine("Введеённое число не является палиндромом");
} else Console.WriteLine("Введите число побольше");