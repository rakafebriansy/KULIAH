import csv, pandas, os #PREPROCESS
def bubblesort(arr,lang):
    for i in range(len(arr)-1,-1,-1):
        for j in range(i):
            if arr[j][lang]>arr[j+1][lang]:
                arr[j], arr[j+1] = arr[j+1], arr[j]
    return arr
def selectionsort(arr,lang):
    for i in range(len(arr)-1):
        min = i
        for j in range(i+1, len(arr)):
            if arr[min][lang] > arr[j][lang]:
                min = j
        arr[i], arr[min] = arr[min], arr[i]
    return arr
def insertionsort(arr,lang):
    for i in range(1,len(arr)):
        x = arr[i]
        j = i-1
        while j >= 0 and x[lang] < arr[j][lang]:
            arr[j+1] = arr[j]
            j-=1
        arr[j+1]= x
    return arr
with open('kamusku.csv','r') as x: #PROCESS
    kamus, namaKolom = [], ['English'.center(23,' '),'Indonesia'.center(23,' ')]
    for i in csv.reader(x):
        kamus.append(i)
    mode = input('Diurutkan Berdasarkan (ENG/IDN)    ').upper()
    sort = input('\n(1) Bubble Sort\n(2) Selection Sort\n(3) Insertion Sort\nPilih salah satu metode diatas!    ')
    if mode == 'ENG' or mode == 'IDN':
        if sort == '1':
            print(pandas.DataFrame(bubblesort(kamus,0), index = [i + 1 for i in range(len(kamus))], columns=namaKolom)
                if mode == 'ENG' else pandas.DataFrame(bubblesort(kamus,1), index = [i + 1 for i in range(len(kamus))], columns=namaKolom))
        elif sort == '2':
            print(pandas.DataFrame(selectionsort(kamus,0), index = [i + 1 for i in range(len(kamus))], columns=namaKolom)
                if mode == 'ENG' else pandas.DataFrame(selectionsort(kamus,1), index = [i + 1 for i in range(len(kamus))], columns=namaKolom))
        elif sort == '3':
            print(pandas.DataFrame(insertionsort(kamus,0), index = [i + 1 for i in range(len(kamus))], columns=namaKolom)
                if mode == 'ENG' else pandas.DataFrame(insertionsort(kamus,1), index = [i + 1 for i in range(len(kamus))], columns=namaKolom))