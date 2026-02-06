namespace Leetcode_pomoc
{
	internal class MergeSortedArray
	{
		public void MergeSortedArrayMethod(int[] nums1, int m, int[] nums2, int n)
		{
			if (n == 0) return;

			for (int i = n-1;  i >= 0; i--)
			{
				nums1[m+i] = nums2[i];
			}
			Array.Sort(nums1);

			//ignore in solution
			/*foreach (var item in nums1)
			{
				Console.Write(item);
			}*/			
		}
	}
}
