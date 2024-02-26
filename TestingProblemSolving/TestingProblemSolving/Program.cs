using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using TestingProblemSolving;

class Result
{

    /*
     * Complete the 'formingMagicSquare' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY s as parameter.
     */

    public static int formingMagicSquare(List<List<int>> s)
    {
        int cost = 0;
        for (int i = 0; i < 3; i++)
        {
            int rowSum = s[i].Sum();
            int columnSum = 0;
            for (int j = 0; j < 3; j++)
            {
                columnSum += s[j][i];
            }

            Console.WriteLine($"Row {i} sum: {rowSum}");
            Console.WriteLine($"Column {i} sum: {columnSum}");

            if(rowSum != 15 || columnSum != 15)
            {
                if(rowSum == columnSum )
                {
                    cost += Math.Abs(rowSum - 15);
                }
                if(rowSum != columnSum)
                {
                    cost += Math.Abs(rowSum - columnSum);
                }
                
            }

        }
        return cost;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        Day2Problems problems = new Day2Problems();

        //Problem 1
        //List<List<int>> numbers = new List<List<int>>();
        //numbers.Add(new List<int>() { 11, 2, 4 });
        //numbers.Add(new List<int>() { 4, 5, 6 });
        //numbers.Add(new List<int>() { 10, 8, -12 });
        //int result = problems.diagonalDifference(numbers);
        //Console.WriteLine(result);

        List<int> input = new List<int> { 63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44 };
        problems.countingSort(input);

    }
}
