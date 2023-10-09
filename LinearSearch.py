list1 = [11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31]
x = 22
def linearSearch(arr, data, iterate = 0):
    for i,j in enumerate(arr):
        iterate+=1
        if j == data:
            return f'Data {j} berhasil ditemukan pada indeks ke-{i} dengan {iterate} iterasi'
print(linearSearch(list1,x))