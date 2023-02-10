void enterSize(int[] size) {
    string[] parameter = {"Line", "Column"};
    for (int x = 0; x < size.Length; x++) {
        Console.Write($"Write number {parameter[x]} > ");
        size[x] = Convert.ToInt32(Console.ReadLine());
    }  
}

void fillingMatrix (int[,,] matrix) {
    Random random = new Random();
    for (int z = 0; z < 2; z++) {
        for (int x = 0; x < matrix.GetLength(0); x++){
            for (int y = 0; y < matrix.GetLength(1); y++) {
                matrix[x, y, z] = random.Next(1, 10);   
            }}}}

void display(int[,,] matrix) { 
    for (int z = 0; z < 2; z++) {
        for (int x = 0; x < matrix.GetLength(0); x++){
            for (int y = 0; y < matrix.GetLength(1); y++) {
                Console.Write(matrix[x, y, z] + "\t");
            } Console.Write("\n");
    }Console.WriteLine("_____________________");
}}

void multiplicationMatrix(int[,,] matrix) { 
    for (int z = 0; z < matrix.GetLength(0); z++){
        for (int x = 0; x < matrix.GetLength(0); x++){
            for (int y = 0; y < matrix.GetLength(1); y++) {
            matrix[z, x, 2] += matrix[z, y, 0] * matrix[ y, x, 1]; 
            }
        }
    }
}

void displayResult(int[,,] matrix) { 
    Console.WriteLine("Result");
        for (int x = 0; x < matrix.GetLength(0); x++){
            for (int y = 0; y < matrix.GetLength(1); y++) {
                Console.Write(matrix[x, y, 2] + "\t");
            } Console.Write("\n");
}}

int[] size = new int[2];
enterSize(size);
int[,,] matrix = new int[size[0], size[1], 3];
fillingMatrix(matrix);
display(matrix);
multiplicationMatrix(matrix);
displayResult(matrix);