namespace Leetcode_pomoc
{
	internal class AddBinaryA
	{


		public string AddBinaryMethod(string a, string b)
		{
			string longer = string.Empty;
			string shorter = string.Empty;
			int diff = 0;
			bool carry = false;

			if (a.Length >= b.Length)
			{
				longer = a;
				shorter = b;
			}
			else
			{
				longer = b;
				shorter = a;
			}

			diff = longer.Length - shorter.Length;
			carry = false;

			for (int i = shorter.Length - 1; i >= 0; i--)
			{
				bool bitA = longer[i + diff] == '1';
				bool bitB = shorter[i] == '1';

				if (bitA && bitB && carry)
				{
					longer = longer.Remove(i + diff, 1).Insert(i + diff, "1");
				}
				else if (bitA && bitB || bitA && carry || bitB && carry)
				{
					carry = true;
					longer = longer.Remove(i + diff, 1).Insert(i + diff, "0");
				}
				else if (bitA || bitB)
				{
					carry = false;
					longer = longer.Remove(i + diff, 1).Insert(i + diff, "1");
				}
				else if (carry)
				{
					carry = false;
					longer = longer.Remove(i + diff, 1).Insert(i + diff, "1");
				}

			}

			if (carry && diff == 0)
			{
				string temp = "1" + longer;
				return temp;
			}
			else if (carry && diff != 0)
			{
				for (int i = diff - 1; i >= 0; i--)
				{
					if (longer[i] == '1')
					{
						longer = longer.Remove(i, 1).Insert(i, "0");
					}
					else if (longer[i] == '0')
					{
						longer = longer.Remove(i, 1).Insert(i, "1");
						carry = false;
						break;
					}
				}

				if (carry)
				{
					longer = "1" + longer;
				}
			}

			return longer;
		}
	}
}
