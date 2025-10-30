public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int sum;
        for(int i = 0; i < nums.Length; i++){
            for (int j = 1; j < nums.Length; j++){
                sum = nums[i] + nums[j];
                if(sum == target){
                    return new int[] { i, j };
                }
            }
        }
        return null;
        
    }
}
