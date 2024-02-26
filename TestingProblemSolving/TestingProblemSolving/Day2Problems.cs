using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProblemSolving
{
    internal class Day2Problems
    {
        public  int diagonalDifference(List<List<int>> arr)
        {
            int leftRightSum = 0;
            int rightLeftSum = 0;
            for (int i = 0; i < arr.Count; i++) 
            {
                leftRightSum += arr[i][i];
            }
            for (int i = arr.Count-1, j = 0; i > -1; i--,j++)
            {
                rightLeftSum += arr[i][j];
            }
            return Math.Abs(leftRightSum - rightLeftSum);
            
        }
        public List<int> countingSort(List<int> arr)
        {
            int[] results = new int[100];
            foreach (int i in arr)
            {
                results[i]++;
            }
            return results.ToList();
        }
        public int flippingMatrix(List<List<int>> matrix)
        {
            List<List<int>> ints = new List<List<int>>();

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix.Count; j++)
                {

                }
            }
        }
    }
}
