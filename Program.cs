using System.Runtime.InteropServices;

namespace NumberGenerator;

class Program
{
    static void Main(string[] args)
    {
        //Generate random number between 1 and 50
        Random rng = new();
        List<int> mainArray = new(25);
        int[] numbers = new int[25];

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = rng.Next(1,51);
                while(numbers.Contains(num)) {
                    num = rng.Next(1, 51);
                }
                numbers[i] = num;
                
            }

            // int counter = 1;
            // for (int i = 0; i < numbers.Length; i++) {
            //     System.Console.Write($"|{numbers[i]}| ");
            //     counter++;
            // }
            var sortedArray = numbers.OrderBy(i => i);
            foreach (var item in sortedArray) {
                System.Console.Write($"|{item}|");
            }
    }
}
