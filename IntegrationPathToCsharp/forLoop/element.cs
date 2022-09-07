using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.forLoop
{
    public class element
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                //assigned value of index to value itself
                //so its going to be like this  index = value
                //0 -> 0
                //1 -> 1
                nums[i] = i + 5;
            }
            for (int j = 0; j < nums.Length; j++)
            {
                //here first loop equal to second 
                //j will always be from 1 to 9 
                //num[j] means numbers from 1 st loop display at the position of j
                //Elements 0 = 5
                //Elements 1 = 6
                //Elements 2 = 7
                //Elements 3 = 8
                //Elements 4 = 9
                //Elements 5 = 10
                //Elements 6 = 11
                //Elements 7 = 12
                //Elements 8 = 13
                //Elements 9 = 14
                Console.WriteLine("Elements {0} = {1}", j, nums[j]);
            }

            //same thing as above lines but in for each loop
            int counter = 0; 
            foreach (int k in nums)
            {
                Console.WriteLine("Elements {0} = {1}", counter, k);
                counter++;
            }
        }
    }
}
