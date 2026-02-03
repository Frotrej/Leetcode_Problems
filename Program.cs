using System.ComponentModel.DataAnnotations;

namespace Leetcode_pomoc
{
    internal class Program
    {
        static void Main()
        {
            int[] a = { 0 };
            int[] b = { 1 };

            MergeSortedArray merge = new MergeSortedArray();
            merge.MergeSortedArrayMethod(a, 0, b, b.Length);

		}
	}
}
