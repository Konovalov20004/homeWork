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

void sorting(int[,] matrix) {
    for (int x = 0; x < matrix.GetLength(0); x++) {
        int y = 0;
        while (y < matrix.GetLength(1) - 1 ) {
            int count = 1;
            if (matrix[x, y] < matrix[x, y + 1]) {
                int temporary = matrix[x, y];
                matrix[x, y] = matrix[x, y +1];
                matrix[x, y + 1] = temporary;
                count++; 
            }if (y < matrix.GetLength(1) - 1) y++;
            if (count > 1) y = 0; 
        }
    }
}

int[] size = new int[2];
enterSize(size);
int[,] matrix = new int[size[0], size[1]];
fillingMatrix(matrix);
Console.WriteLine("Before sorting");
display(matrix);
sorting(matrix);
Console.WriteLine("After sorting");
display(matrix);