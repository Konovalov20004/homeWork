int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int sum (int M, int N) {
    if (M == N) return M;
    return M = M + sum(M + 1, N);
}

int display = sum(M, N);
Console.WriteLine(display);