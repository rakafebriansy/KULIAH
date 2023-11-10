subArray1 = [1,5,10,12]
subArray2 = [6,9]
def merge(arr1,arr2):
    newArray = []
    for i in range(len(arr1)+len(arr2)):
        if len(arr1) != 0 and len(arr2) != 0:
            newArray.append(arr1.pop(0)) if arr1[0] < arr2[0] else newArray.append(arr2.pop(0))
        else:
            newArray.append(arr2.pop(0)) if len(arr1) == 0 else newArray.append(arr1.pop(0))
    return newArray
print(merge(subArray1,subArray2))