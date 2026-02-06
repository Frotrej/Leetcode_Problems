using System.ComponentModel.DataAnnotations;

namespace Leetcode_pomoc
{
    internal class Program
    {
        static void Main()
        {
            int[] a = { 3, -2, 1, 1 };
            TransformedArray ta = new TransformedArray();
            int[] b = ta.TransformedArrayMethod(a);

            foreach (var item in b)
            {
                Console.Write($"{item},");
			}

		}
	}
}
