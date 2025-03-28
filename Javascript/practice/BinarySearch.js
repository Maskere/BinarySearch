function BinarySearch(collection,left,right, target){
    while(left <= right){
        let mid = Math.floor(left + (right - left) / 2)

        if(collection[mid] == target){
            return mid
        }
        else if(collection[mid] < target){
            left = mid + 1
        }
        else{
            right = mid - 1
        }
    }
    return -1
}

const test = [-1,1,5,5,7]
const target = 7
const left = 0
const right = test.length - 1

const result = BinarySearch(test,left,right, target)

if(result != -1){
    console.log("Element found at index: "+result)
}
else{
    console.log("Element not found")
}
