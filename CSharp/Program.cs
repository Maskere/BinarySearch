namespace BinarySearch{
    public class Program{
        static void Main(string[] args){
            List<int> nums = new() {-6,2,5,-2,-7,-1,3};
            nums.Sort((a,b) => a - b);
            //-7,-6,-2,-1,2,3,5

            int target = 6;
            int result = binarySearch(nums,0,nums.Count() -1, target);

            if(result != -1){
                Console.WriteLine("Found target at index: {0}",result);
            }
            else{
                Console.WriteLine("Target not found");
            }
        }

        // two-pointers-approach
        public static int binarySearch(List<int> nums, int low, int high, int target) {
            while(low <= high){
                int mid = low + ((high - low)/2);

                if(nums[mid] == target){
                    return mid;
                }
                else if(nums[mid] < target){
                    low = mid + 1;
                }
                else{
                    high = mid -1;
                }
            }
            return -1;
        }
    }
}
