public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Array.Sort(nums);
        
        int freq = 1; 
        List<int> result = new List<int>();

        for(int i = 1; i<nums.Length; i++){
            if(nums[i] == nums[i-1]){
                freq++;
            }
            else{
                 if (freq > nums.Length / 3){
                    result.Add(nums[i - 1]);
                }
                freq = 1;
            }
        }
        if (freq > nums.Length / 3){
            result.Add(nums[nums.Length-1]);
        }
        return result;
    }
}