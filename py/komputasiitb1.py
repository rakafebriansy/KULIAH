A = int(input('Masukkan harga dasar barang A: '))
AA = int(input('Masukkan harga jual barang A: '))
B = int(input('Masukkan harga dasar barang B: '))
BB = int(input('Masukkan harga jual barang B: '))
C = int(input('Masukkan harga dasar barang C: '))
CC = int(input('Masukkan harga jual barang C: '))

dif1 = AA - A
dif2 = BB - B
dif3 = CC - C

if dif1 > dif2 and dif1 > dif3:
    result = 'A'
elif dif1 < dif2 and dif2 > dif3:
    result = 'B'
elif dif1 < dif3 and dif2 < dif3:
    result = 'C'

print(f'Barang yang harus ditawarkan adalah barang {result}')
