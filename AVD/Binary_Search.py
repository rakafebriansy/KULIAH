list1 = [11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31]
x = 22
def binarySearch(arr, data, iterate = 0):
    low, high = 0, len(arr)-1
    while low <= high: 
        iterate+=1
        mid = (low+high)//2 
        if arr[mid] == data:
            return f'Data {arr[mid]} berhasil ditemukan pada indeks ke-{mid} dengan {iterate} iterasi'
        elif arr[mid] > data:
            high = mid-1
        else:
            low = mid + 1
    return None
print(binarySearch(list1,x))