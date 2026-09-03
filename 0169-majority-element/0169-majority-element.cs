public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        
        int freq = 1; 
        int ans  = nums[0];

        for(int i = 1; i<nums.Length; i++){
            if(nums[i] == nums[i-1]){
                freq++;
            }
            else{
                freq = 1;
                ans = nums[i];
            }

            if (freq > nums.Length / 2){
                return ans;
            }

        }
        return ans;
    }
}