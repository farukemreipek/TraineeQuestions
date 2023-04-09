using System;

namespace TraineeQuestions
{
    /// <summary>
    /// Calculate the total sum of items from a given array.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// Geriye int tipinde parametre olarak int bir dizi alan, Class içerisinde method yazdım
            /// Yukarıda ise çağırarak methodun istediği diziyi verdim.
            /// </summary>

            int[] testData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = Math.Calculate(testData);

            Console.WriteLine($"toplam = {result}");

            /// <summary>
            /// Burada ise dizinin uzunluğu kadar 0,dizinin uzunluğu kadar döndürdüm dönerken dizinin içinde ki
            /// sayıları teker teker toplattırdım 
            /// testData[0]= > 1 
            /// testData[1]= > 2
            /// </summary>

            var total = 0;
            for (int i = 0; i < testData.Length; i++)
            {
                total = testData[i] + total;
            }
            Console.WriteLine($"toplam = {total}");

        }
    }
    class Math
    {
        public static int Calculate(int[] numbers)
        {
            var total = 0;
            foreach (var item in numbers)
            {
                total = total + item;
            }
            return total;
        }
    }
}
