def conquer(left, right, gap):
    return left+right, gap
def divide(a, gap=0):
    if len(a) == 1:
        return a, gap
    else:
        mid = len(a)//2
        left, gap = divide(a[:mid], gap)
        right, gap = divide(a[mid:], gap)
        newGap = abs(left[-1] - right[0])
        gap = newGap if newGap > gap else gap
    return conquer(left, right, gap)
array, gap = divide([12,1,1,2,5,7,6,9,14])
print(gap)