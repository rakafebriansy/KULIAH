def linearsearch(arr,k):
    count = 0
    for i in arr:
        for j in arr:
            if j - i == k:
                count+=1
    return count
data = [1,2,2,5,9,13,14,17]
print(linearsearch(data,3))