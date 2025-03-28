def binarySearch(collection,low,high,target):
    while low <= high:
        mid = low + (high - low) // 2 #make sure to floor the result!!!

        if collection[mid] == target:
            return mid;
        elif collection[mid] < target:
            low = mid + 1
        else:
            high = mid - 1

    return -1

nums = [-7,1,2,7,3,1,-9,-45,-12]
nums.sort()

target = -7
low = 0 #want to search from index 0
high = len(nums) - 1 #want to search to the last index

result = binarySearch(nums,low,high,target)
if result == -1:
    print("Element not found")
else:
    print("Element found at index:",str(result))
