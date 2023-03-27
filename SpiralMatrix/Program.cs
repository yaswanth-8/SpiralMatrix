﻿namespace MyProject;
class Program
{
    static void Main(string[] args){
         int[,] matrix = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };
        int rows = 3;
        int cols = 4;
        int top = 0;
        int bottom = rows - 1;
        int left = 0;
        int right = cols - 1;
        while (top <= bottom && left <= right){

            for (int i = left; i <= right; i++){
                Console.Write(matrix[top, i] + " ");
            }
            top++;

            for (int i = top; i <= bottom; i++){
                Console.Write(matrix[i, right] + " ");
            }
            right--;

            if (top <= bottom){
                for (int i = right; i >= left; i--)
                {
                    Console.Write(matrix[bottom, i] + " ");
                }
                bottom--;
            }

            if (left <= right) { 
                for (int i = bottom; i >= top; i--)
                {
                    Console.Write(matrix[i, left] + " ");
                }
                left++;
            }
        }
    }
}