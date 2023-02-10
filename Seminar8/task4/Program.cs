int [][] size = new int[][] { new int[2], new int[2], new int[2]};
void sizeEnter(int[][] size) {
    for (int x = 0; x < size.Length - 1; x++) {
    string[] nameParameter = {"line", "column"};
    Console.Write($"How {nameParameter[x]} > ");
    size[x][1] = Convert.ToInt32(Console.ReadLine());
    size[2][x] = size[x][1];}}

void fillingMatrix(int[,] matrix) {
    int course = 1;
    int line = size[0][0];
    int column = size[1][0];
    int count = 0;
    while (count < matrix.Length){
        for (int x = size[1][0]; x < size[1][1] && x >= size[1][0]; x++) {
            count++;
            matrix[line, column] = count;
            column+= course;
        } if (column < size[1][0] || column >= size[1][1]) {column-= course;}
        if (course > 0) {size[0][0]++; line = size[0][0];} else {size[0][1]--; line = size[0][1] - 1;}  
    for (int x = size[0][0]; x < size[0][1] && x >= size[0][0]; x++) {
            count++;
            matrix[line, column] = count;
            line+= course;
        } if (course > 0) {size[1][1]--; column = size[1][1]-1;} else {size[1][0]++; column = size[1][0];}
        if (line < size[0][0] || line >= size[0][1]) { line-= course;}
        course*= -1;
        }
    }


sizeEnter(size);
int[,] matrix = new int[size[2][0], size[2][1]];
fillingMatrix(matrix);
for (int x = 0; x < matrix.GetLength(0); x++) {
            for (int y = 0; y < matrix.GetLength(1); y++) {
                Console.Write(matrix[x, y] + "\t");
            } Console.Write("\n");}