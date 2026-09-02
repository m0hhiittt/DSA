public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = int.MinValue;
        int currentSum = 0;

        for(int i=0; i<nums.Length; i++){
            currentSum += nums[i];
                max = Math.Max(currentSum,max);
                if(currentSum<0){
                    currentSum = 0;
                }
        }

        return max;
    }
}