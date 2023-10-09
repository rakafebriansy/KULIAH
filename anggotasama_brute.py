# Implementasi algoritma brute force
def brute_anggotasama(a, k):
    count = 0
    for i in range(len(a)):
        if a[i] == k:
            count += 1
    return count

A = [3, 5, 2, 6, 1, 5, 7, 5]
key = 5

print("Brute Force: ", brute_anggotasama(A, key))
