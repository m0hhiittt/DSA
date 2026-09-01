public class Solution {
    public string ReverseVowels(string s) {
        char[] arr = s.ToCharArray();

        int left = 0;
        int right = arr.Length -1;

        for(int i=0; i<arr.Length; i++){
            if (left >= right)
                break;

            if(!IsVowel(arr[left])){
                left++;
                continue;
            }

            if(!IsVowel(arr[right])){
                right--;
                continue;
            }

            if(left<right){
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
        return new string(arr);
    }

    public bool IsVowel(char c){
        return c== 'a' || c== 'e' || c== 'i' || c== 'o' || c== 'u' ||
        c=='A' || c== 'E' || c== 'I' || c== 'O' || c== 'U';
    }
}