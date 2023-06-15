'''PEMBUATAN FUNCTION'''
#BUAT FUNCTION HILANGKAN SPECIAL CHARACTER KECUALI '
def mencariUrutan(kalimatBaru,kata, i =0):
    if kalimatBaru[0] == kata:
        return i
    else:
        return mencariUrutan(kalimatBaru[1:],kata,i+1)
    
def banyakDicari(kalimatBaru,listKata):
    listUrutanKata = []
    for kata in listKata:
        listUrutanKata.append([kata,mencariUrutan(kalimatBaru,kata)])
    return listUrutanKata

'''PROSES'''
kalimat  = "Lorem ipsum dolor sit amet consectetur RAKA adipisicing elit Numquam quasi corporis AIS fuga quaerat beatae reiciendis sit AHA non fugit unde laudantium"
listKata = ["AIS","RAKA","AHA"]    #GANTI VARIABEL kalimat DAN kata KE INPUT
#JALANKAN FUNCTION MENGHILANGKAN SPECIAL CHARACTER KECUALI '
kalimatBaru = kalimat.split()
listHasil = banyakDicari(kalimatBaru,listKata)
for hasil in listHasil:
    print(f'KATA {hasil[0]} DITEMUKAN PADA URUTAN KE {hasil[1]}')