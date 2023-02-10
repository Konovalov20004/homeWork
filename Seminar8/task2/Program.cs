void enterSize(int[] size) {
    string[] parameter = {"Line", "Column"};
    for (int x = 0; x < size.Length; x++) {
        Console.Write($"Write number {parameter[x]} > ");
        size[x] = Convert.ToInt32(Console.ReadLine());
    }  
}

void fillingMatrix (int[,] matrix) {
    Random random = new Random();
    for (int x = 0; x < matrix.GetLength(0); x++){
        for (int y = 0; y < matrix.GetLength(1); y++) {
            matrix[x, y] = random.Next(0, 11);   
        }
    }
}

void display(int[,] matrix) { 
    for (int x = 0; x < matrix.GetLength(0); x++){
        for (int y = 0; y < matrix.GetLength(1); y++) {
            Console.Write(matrix[x, y] + "\t");
        } Console.Write("\n");
    }
}

int maxSum (int[,] matrix) {
    int[] sum = new int[matrix.GetLength(0)];
    searchSum(sum);
    int max = sum[0];
    int count = 0;
    foreach (int x in sum) {
        if (x > max) {
        max = x;
        count++;
    }
} return (count+1);
}

int[] size = new int[2];
enterSize(size);
int[,] matrix = new int[size[0], size[1]];
fillingMatrix(matrix);
display(matrix);
Console.WriteLine($"in line {maxSum(matrix)} the maximus amout");

void searchSum(int[] a) {
    for (int x = 0; x < matrix.GetLength(0); x++){
        for (int y = 0; y < matrix.GetLength(1); y++) {
            a[x] += matrix[x, y];
}}}