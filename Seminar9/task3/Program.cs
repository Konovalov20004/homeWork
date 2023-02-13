int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int funcAckermann (int a, int b) {
    if (a == 0) return b + 1;
    if (a > 0 && b == 0) return funcAckermann(a - 1, b + 1);
    return funcAckermann(a - 1, funcAckermann(a , b - 1));
    
}

int x = funcAckermann(a, b);
Console.WriteLine(x);