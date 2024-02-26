using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProblemSolving
{
    internal class problemTwo
    {
        public int lonelyinteger(List<int> a)
        {
            bool unique = true;
            int uniqueInt = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (unique == false) 
                {
                    unique = true;
                }
                
                for (int j = 0; j < a.Count; j++)
                {
                    if (a[i] == a[j] && i != j)
                    {
                        unique = false; break;
                    }
                }
                if(unique == true)
                {
                    return a[i];
                }
            }
            return 5;
        }

        public static int findMedian(List<int> arr)
        {
            arr.Sort((a, b) => a - b);
            int index = Convert.ToInt16(Math.Floor((decimal)arr.Count / (decimal)2) + 1);
            return arr[index];
        }
        public void miniMaxSum(List<int> arr)
        {
            arr.Sort((a, b) => a - b);
            Int64 minSum = 0;
            Int64 maxSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if(i != 0)
                {
                    maxSum += arr[i];
                }
                if(i != arr.Count - 1)
                {
                    minSum += arr[i];
                }
            }
            Console.WriteLine($"{minSum} {maxSum}");
        }

        public string timeConversion(string s)
        {
            string[] splitTime = s.Split(':');
            int hh = Convert.ToInt16(splitTime[0]);
            if (splitTime[2].Substring(2, 1) == "P" && hh != 12)
            {
                hh += 12;
            }
            else if (splitTime[2].Substring(2, 1) == "A" && hh == 12)
            {
                hh -= 12;
            }
            else if (splitTime[2].Substring(2, 1) == "P" && hh == 12)
            {
                hh = 12;
            }
            return $"{hh}:{splitTime[1]}:{splitTime[2].Substring(0, 2)}";
        }
        public void plusMinus(List<int> arr)
        {
            double positive = 0, negative = 0, zero = 0;
            foreach (int item in arr)
            {
                if (item > 0)
                {
                    positive++;
                }
                else if (item < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }

            }

            Console.WriteLine((positive / arr.Count).ToString("F6"));
            Console.WriteLine((negative / arr.Count).ToString("F6"));
            Console.WriteLine((zero / arr.Count).ToString("F6"));
        }
        public List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> rankResults = new List<int>();
            int numberOfRanks = ranked.Distinct().Count();

            for (int i = 0; i < player.Count; i++)
            {
                for (int j = 0; j < ranked.Count; j++)
                {
                    Console.WriteLine($"Current rank looking at: {ranked[j]},  current player Score: {player[i]} \n");
                    if (j != ranked.Count - 1)
                    {
                        if (ranked[j] > player[i] && ranked[j + 1] < player[i])
                        {
                            Console.WriteLine($"Their rank is {j}");
                            rankResults.Add(j);
                        }
                        else if (ranked[j] == player[i])
                        {
                            Console.WriteLine($"Their rank is j");
                            rankResults.Add(j);
                        }
                        else if (ranked[0] < player[i])
                        {
                            Console.WriteLine($"Their rank is 1");
                            rankResults.Add(1);
                            break;
                        }


                    }
                    else
                    {
                        if (ranked[j] > player[i])
                        {
                            Console.WriteLine($"Their rank is {numberOfRanks + 1}");
                            rankResults.Add(j);
                        }
                    }

                }

            }
            return rankResults;

        }

        public void runProblem()
        {
            List<int> rank = new List<int>() {100,100,50,40,40,20,10 };
            List<int> player = new List<int>() { 5, 25, 50, 120 };

            List<int> result = climbingLeaderboard(rank, player);
        }
    }
}
