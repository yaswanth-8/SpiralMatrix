namespace MyProject;
class Program
{
    static void display(int[,] matrix, int rows, int columns)
    {
        int top = 0;
        int bottom = rows - 1;
        int left = 0;
        int right = columns - 1;
        while (top <= bottom && left <= right){

            for (int i = left; i <= right; i++){
                Console.Write(matrix[top, i] + " ");
            }
            top++;
            Console.WriteLine();
            for (int i = top; i <= bottom; i++){
                Console.Write(matrix[i, right] + " ");
            }
            right--;
            Console.WriteLine();
            if (top <= bottom){
            for (int i = right; i >= left; i--){
                Console.Write(matrix[bottom, i] + " ");
             }
            bottom--;
            }
            Console.WriteLine();
            if (left <= right){
            for (int i = bottom; i >= top; i--){
                Console.Write(matrix[i, left] + " ");
             }
            left++;
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args){
    int[,] matrix = {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12}
    };
    display(matrix, 3, 4);
    }
}