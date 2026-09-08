public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> median = new List<int>();
        double cf = 0;
        int i = 0;
        int j = 0;

        while(i<nums1.Length && j<nums2.Length){
            if(nums1[i] <= nums2[j]){
                median.Add(nums1[i]);
                i++;
            }
            else{
                median.Add(nums2[j]);
                j++;
            }
        }
        while(i<nums1.Length){
            median.Add(nums1[i]);
            i++;
        }

        while(j<nums2.Length){
            median.Add(nums2[j]);
            j++;
        }
        int temp = 0;
        if(median.Count % 2 == 0){
            temp = median.Count/2;
            cf = (median[temp] + median[temp-1])/2.0;
        }
        else{
            temp = median.Count/2;
            cf = median[temp];
        }
        return cf;
    }
}