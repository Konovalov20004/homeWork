Console.WriteLine("Введите число чтобы проверить палиндром");
int x = Convert.ToInt32(Console.ReadLine());
int y = x;
int c = 0;
int z = 1;

for (int i = y; y >= 1; c++) {
	y = y / 10 ;
	z *= 10;
} 

int u1 = 0;
int u = x;
for (int a = 0; a < c; a++){
    int p = 0;
    p = u % 10;
    u /= 10;
    z /= 10;
    u1 = u1 + p * z;
}

 if ( u1 == x) {
	 Console.WriteLine("Число палиндром");
 } else {
	 Console.WriteLine("Число не палиндром");
 }