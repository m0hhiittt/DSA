public class Solution {
    public int MajorityElement(int[] nums) {
        
        for(int i = 0; i<nums.Length; i++){
            int frequency = 0; 
            for(int j= 0; j<nums.Length; j++){
                if(nums[i] == nums[j]){
                   frequency++;
                }
            }
            if(frequency > nums.Length/2){
                return nums[i];
            }
        }
        return -1;
    }
}