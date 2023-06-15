def interpolationsearch(arr,x,iterate = 0):
    low, high = 0, len(arr)-1
    while low <= high:
        iterate+=1
        mid = (low + int(((high-low) / (arr[high]-arr[low]) * (x - arr[low]))))
        if arr[mid] == x:
            return 'indeks ke ' + str(mid)+ ' dengan '+ str(iterate) + ' iterasi'
        elif arr[mid] > x:
            high = mid - 1
        else:
            low = mid + 1
    return None
data = [1,10,11,20,22,30,33,40,44,50,55,60,66,70,77,80,88,90,99,100]
print(interpolationsearch(data,90))