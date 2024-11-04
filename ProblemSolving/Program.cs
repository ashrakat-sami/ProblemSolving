internal class Program
{
    private static void Main(string[] args)
    {
       




        Console.ReadKey();
    }
}
#region Range sum query immutable
//int[] arr = { -2, 0, 3, -5, 2, -1 };
//NumArray numArray = new NumArray(arr);
//Console.WriteLine(numArray.SumRange(0, 5));

//public class NumArray
//{
//    int[] nums;
//    public NumArray(int[] nums)
//    {

//        this.nums = nums.ToArray();
//        //for (int i=0; i <nums.Length; i++) {

//        //    Console.WriteLine(nums[i]);
//        //}
//    }
//    public int SumRange(int left, int right)
//    {
//        int sum = 0;
//        for (int i = left; i <= right; i++)
//        {
//            sum += nums[i];
//        }
//        return sum;
//    }

//}
#endregion

#region TwoSum

//Solution solution = new Solution();
//int[] arr = { 2, 3, 5 };
//int[] arr2 = solution.TwoSum(arr, 7);

//Console.WriteLine(string.Join(", ", arr2));
//public  class Solution
//{
//    public  int[] TwoSum(int[] nums, int target)  //1,2,3,4

//    {

//        for (int i=0; i<nums.Length;i++)
//        {
//            for (int j = 1; j < nums.Length; j++) {
//                if (nums[i] + nums[j] == target && i != j)
//                { //int[] arr = { i, j };
//                    return [i,j];
//                        }
//            }

//        }

//        return [1];
//    }
//}
#endregion

#region IsPalindrome
//Solution solution = new Solution();
//Console.WriteLine(solution.IsPalindrome(121));
//public class Solution
//{
//    public bool IsPalindrome(int x) //121 //123
//    {
      
//      var y= x.ToString().ToCharArray();
//       var z= x.ToString().ToCharArray().Reverse();
       
//        if(y.SequenceEqual(z)) return true;   

//        return false;
//    }
//}
#endregion

