def merge1(left, right):
    result, i, j = [], 0, 0
    while i < len(left) and j < len(right):
        if left[i] < right[j]:
            result.append(left[i])
            i += 1
        else:
            result.append(right[j])
            j += 1
    while (i < len(left)):
        result.append(left[i])
        i += 1
    while (j < len(right)):
        result.append(right[j])
        j+=1
    return result
def mergesort1(arr):
    if len(arr)<2:
        return arr
    else:
        mid = len(arr)//2
        left, right = mergesort1(arr[:mid]), mergesort1(arr[mid:])
    return merge1(left,right)
print(mergesort1([6,5,12,10,9,1]))