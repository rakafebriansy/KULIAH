kiri = 'qwertasdfgzxcvb'
kanan = 'yuiophjklnm'
array = []
boolean = True
in1 = input()
for a in in1:
    if a in kiri:
        array.append(1)
    elif a in kanan:
        array.append(2)
for b in range(len(array)-1):
    if array[b] == array[b+1]:
        boolean = False
print(boolean)