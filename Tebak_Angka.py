import random #INI ADALAH MODULE RANDOM
angka = random.randint(0,100)
kondisi = True
for kesempatan in range(10): #'in range(10)' MEMBERIKAN PEMAIN 10 KALI KESEMPATAN MENEBAK
    in1 = int(input(f'TEBAK 1-100!(percobaan ke-{kesempatan+1})')) #INPUT YANG BERULANG SEBANYAK 10 KALI DISERTAKAN INFORMASI BANYAK PERCOBAAN
    if in1 < angka : #OPERASI KONDISIONAL 1
        print(f'Angka terlalu kecil')
    elif in1 > angka : #OPERASI KONDISIONAL 2
        print(f'Angka terlalu besar')
    elif in1 == angka : #OPERASI KONDISIONAL 3
        print(f'Angka anda benar setelah menebak {kesempatan+1} kali')
        kondisi = False
        break #'break' UNTUK MENGHENTIKAN PERULANGAN
if kesempatan >= 9 and kondisi == True: #OUTPUT JIKA SALAH DALAM 10x PERCOBAAN
    print(f'\nAnda belum beruntung\nJawaban:{angka}')