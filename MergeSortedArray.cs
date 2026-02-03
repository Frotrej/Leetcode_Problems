namespace Leetcode_pomoc
{
	internal class MergeSortedArray
	{
		public void MergeSortedArrayMethod(int[] nums1, int m, int[] nums2, int n)
		{
			int trueM = m - n;

			if (n == 0) return;
			else if (m == 0) m = 0;
				
			for (int i = n-1; i >= 0; i--)
			{
				nums1[trueM+i] = nums2[i];
			}
			Array.Sort(nums1);



			foreach (var item in nums1)
			{
				Console.Write(item);
			}
			
		}
	}
}
