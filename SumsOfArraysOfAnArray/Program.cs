using System;

namespace TraineeQuestions
{
    /// <summary>
    /// // Calculate individual sum of each array in a given array. And assing each result to another array.
    //Belirli bir dizideki her dizinin bireysel toplamını hesaplayın. Ve her sonucu başka bir diziye atamak.

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[][] testData = {
                new int[] { 1,2},
                new int[] { 2, 2 },
                new int[] { 3, 2 },
            };
            //Output => Array[{},4,5,]
            Math.Calculate(testData);
        }

    }
    public class Math
    {
        public static int[] Calculate(int[][] values)
        {
            int[] dizi = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                //i =0 3 length
                //i = 1 2 length
                //i = 2 2 length
                //i = 3 1 length
                var colTotal = 0;
                for (int j = 0; j < values[i].Length; j++)
                {
                    colTotal = colTotal + values[i][j];

                }
                dizi[i] = colTotal;

                Console.WriteLine(dizi[i]);
            }
            return dizi;
        }
    }

}