//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IntegrationPathToCsharp.Collections
//{
//    internal class program11
//    {
//		public static void main(String[] args)
//		{

//			int[] numbers = new int[] { -2, 3, 7, 4, 8 };
//			int target = 10;
//			int[] result = getTwoSum(numbers, target);
//			//System.out.println(result[0] + " " + result[1]);

//		}

//		public static int[] getTwoSum(int[] numbers, int target)
//		{
//			Map<Integer, Integer> visitedNumbers = new HashTable<>();
//			for (int i = 0; i < numbers.Length; i++)
//			{
//				int delta = target - numbers[i];
//				if (visitedNumbers.containsKey(delta))
//				{
//					return new int[] { i, visitedNumbers.get(delta) };

//				}
//				visitedNumbers.put(numbers[i], i);
//			}
//			return new int[] { -1, -1 };
//		}

//	}
//}
