int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
 
if (M % 2 == 0) Console.Write(sum(M, N));
else M+= 1; Console.Write(sum(M, N));

string sum(int M, int N) {
if (M >= N || M == N - 1) return $"{M} "; 
return $"{M} " + sum(M + 2, N);
} 