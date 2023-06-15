# Implementasi algoritma divide and conquer
def divide_anggotasama(a, k):
    if len(a) == 1:
        if a[0] == k:
            return 1
        else:
            return 0
    else:
        mid = len(a) // 2
        left_count = divide_anggotasama(a[:mid], k)
        right_count = divide_anggotasama(a[mid:], k)
        return left_count + right_count
A = [3, 5, 3, 6, 3, 3, 7, 5]
key = 12

print("Divide and Conquer: ", divide_anggotasama(A, key))