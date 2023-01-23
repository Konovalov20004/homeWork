// Ради приличного вывода и ввода данных пришлось запариться в выведением данных и записыванием
// их в целочисленный массив.
char[] AB = new char[] {'A','B'};
char[] z = new char[] {'x' ,'y' ,'z'};
int[,] a = new int [3,2];
int count = 2;
for ( int i = 0; i < count; i++) {
	Console.WriteLine($"Введите координаты точки {AB[i]}:");
	for (int o = 0; o < 3; o++) {
		Console.WriteLine($"Введите координаты оси {z[o]}");
		int t = Convert.ToInt32(Console.ReadLine());
		a[o, i] = t;	
	};
} 
//Формула для нахождения расстояния между точками
double S = Math.Sqrt(Math.Pow(a[0, 0] - a[0, 1], 2) + Math.Pow(a[1, 0] - a[1, 1], 2) + Math.Pow(a[2, 0] - a[2, 1], 2));
Console.WriteLine($" Расстояние от точки А до точки В = {S}");
