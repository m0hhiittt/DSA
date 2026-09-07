public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int i= 0; i<nums.Length; i++){
            for(int j=i; j<nums.Length; j++){
                if(nums[i] == 0){
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i]= temp;
                }
            }
        }
    }
}