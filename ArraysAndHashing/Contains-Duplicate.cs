namespace ArraysAndHashing;
/*
https://leetcode.com/problems/contains-duplicate/

Given an integer array nums, return true if any value appears at least twice in the array,
and return false if every element is distinct.

 Example 1:
Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
*/

public class Contains_Duplicate
{

 public bool ContainsDuplicate(int[] nums)
 {
  HashSet<int> result = new HashSet<int>();

  if (nums.Length == 1)
   return false;

  foreach (var num in nums)
  {
   if (result.Contains(num))
    return true;
   else
   {
    result.Add(num);
   }
  }
  return false;
 }
    
}