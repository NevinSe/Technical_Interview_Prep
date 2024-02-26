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
        problemTwo problem = new problemTwo();

        //List<int> ints = new List<int>{ -4, 3, -9, 0, 4, 1 };
        //problem.plusMinus(ints);
        //List<int> ints2 = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };
        //problem.miniMaxSum(ints2);

        //string test = problem.timeConversion("12:45:54PM");
        //Console.ReadLine();
        List<int> ints = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
        int result = problem.lonelyinteger(ints);
        Console.ReadLine();
        //List<List<int>> s = new List<List<int>>()
        //{
        //    new List<int> { 4, 9, 2 },
        //    new List<int> { 3, 5, 7 },
        //    new List<int> { 8, 1, 5 }
        //};

        //List<List<int>> s2 = new List<List<int>>()
        //{
        //    new List<int> { 5, 1, 8 },
        //    new List<int> { 7, 5, 3 },
        //    new List<int> { 2, 9, 4 }
        //};



        //List<List<int>> s3 = new List<List<int>>()
        //{
        //    new List<int> { 4, 8, 2 },
        //    new List<int> { 4, 5, 7 },
        //    new List<int> { 6, 1, 6 }
        //};





        //int result = Result.formingMagicSquare(s3);

        //Console.WriteLine(result);


    }
}
